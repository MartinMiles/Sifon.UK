# Shared Forms API

From time to time you may want to benefit from using existing user control just immediately from your plugin. You have several options for doing that:

- writing the form inline with PowerShell GUI
- creating a form in Visual Studio in a separate DLL

With Sifon you may of course do either of the approaches, but the fact to consider is that both will rub for local profile only. When running a remote profile, Sifon copies your script to a remote machine and  genuinely executes it in the context of a remote machine and by means of that remote machine. It only intercepts several output streams from a remote machine, such as Output, Warning, Progress and Error which leaves us without any way to interact with GUI done with Winforms.


<br/>

## Sample plugin requirements

However, some limited options of creating **universal plugin** with GUI input still exist. By saying universal it meant a plugin will function regardless of if the profile is local or remote. You as developer should always try creating universal plugins, unless you are not sharing your scripts and working locally only. Let's assume the following plugin requirements exist:

- plugin requires user picking and providing Sitecore license 
- you want user to pick up the license file with GUI filepicker
- plugin must execute on both local and remote machine, depending on a context of selected profile
- license file picker operates on a local machines always and cares about copying license to a remote host (for remote profiles)

[Sifon Controls Library](/docs/Library.md "Sifon Controls Library") already has a suitable control for us - **LocalFilePicker**. And that's how it looks in action:

![LocalFilePicker in action](https://raw.githubusercontent.com/wiki/MartinMiles/Sifon/img/API/LicenseSelector.png "LocalFilePicker in action") 


<br/>

## Sample plugin implementation - local only

If there wasn't a requirement for a plugin also to run remotely, the solution would be as simple as that:

```
$form = new-object Sifon.Shared.Forms.LocalFilePickerDialog.LocalFilePicker
$form.StartPosition = [System.Windows.Forms.FormStartPosition]::CenterParent;

$form.Caption = "Sitecore license selector";
$form.Filters = "License files|*.xml";
$form.Label = "Select Sitecore license in order to install Horizon:";
$form.Button = "OK";

# Validation is optional, just uncomment below. Also, the line below is a nice way of passing inline logic as a delegate into DLL without losing types:
# $form.Validation = { [Validation.FilePicker]::IsSitecoreLicense($args[0]) }

$result = $form.ShowDialog()

$licenseMessage = 
if ($result -ne [System.Windows.Forms.DialogResult]::OK -or [string]::IsNullOrEmpty($SelectedFile))
{
    Write-Output "Sitecore license required for Horizon installation"
    exit
}
# send the file to remote and do the rest of your tasks with a license file received
```
The above code forks pretty well and it will instantiate a new popup window of `LocalFilePicker` over Sifon in order to select a file from your computer and pass the resulted file full path further into a plugin script. The above approach is called PowerShell GUI and since you can use any of .NET code from your scripts - that remains valid also or Windows Forms.

Unfortunately if the above code is run in a context of a remote machine, Sifon that runs locally won't be able to show you these forms as the whole script been copied and gets executed entirely at the remote machine by WinRM protocol. So we need to find a walkaround to a given scenario.


<br/>

