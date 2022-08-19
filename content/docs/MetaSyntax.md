## Using meta-language

Sometimes you need getting more out your scripts with Sifon and that is the time where script meta-syntax comes into a play. Notice these triple-hash ('###') lines at the top.

Let's look at the working solution below, followed by an explanation on how it works:

```
### Name: Install Horizon for Sitecore 10.0
### Description: Installs Sitecore JSS along with CLI
### Compatibility: Sifon 1.01
### $SelectedFile = new Sifon.Shared.Forms.LocalFilePickerDialog.LocalFilePicker::GetFile("Sitecore license selector","Select Sitecore license in order to install Horizon:","License files|*.xml","OK")
### Display: Local
### Execution: Local

param(
    [string]$Webroot,
    [string]$Website,
    [string]$Prefix,
    [string]$SelectedFile
)

If(!(Test-Path -Path $SelectedFile))
{
    Write-Error "File $SelectedFile does not exist on your local machine"
    exit
}   
```
Please pay attention to the line number 4. Everything starting with `#` is ignored by PowerShell as being a comment, so it is a good opportunity to tell Sifon some necessary additional information, mandatory for a plugin to function. We do that by starting such lines with `###` block and passing Sifon necessary instruction.

In the above example we pass a line that looks very similar to a PowerShell code:
```
### $SelectedFile = new Sifon.Shared.Forms.LocalFilePickerDialog.LocalFilePicker::GetFile("Sitecore license selector","Select Sitecore license in order to install Horizon:","License files|*.xml","OK")
```
What happens under the bonnet is Sifon finding such meta-syntax instructions executes them in a local context prior to running a script that could be run a remote context. In this example, it instantiates a LocalFilePicker form and calls its method `GetFile()` passing all the required parameters. This is the same class as shown in a previous PowerShell GUI example, that draws you a file selector form. 

Once file get selected, it is being assigned to an input parameter `$SelectedFile` as declared. Please pay attention to the following:

- parameter `$SelectedFile` is below accepted as an income parameter to a script
- this parameter is not part of profile, but being added and assigned from the above meta-syntax line
- script may be executed in a remote machine context
- for remote scripts selected file is automatically copied to a target machine and resulted remote file path automatically assigned to a variable
- this path on remote machine will likely be different, as your local file is copied into Sifon working folder at the remote

To sum up - you as a script developer need to do:

1. using one-liner as above, declare a variable and assign it with an output from a locally running (not mandatory) GUI code or whatever you need
2. receive same variable within `param(...)` block and use it in you locally and remotely running script.

No need to mess up with establishing remote connection and copying the selected file there - Sifon will do it all for you and will assign your declared variable with a correct path!


<br/>

[<- Home](/ "Home")	
