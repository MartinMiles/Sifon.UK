# Text Editor

<!-- ![PackageVersionSelector](../../img/SharedAPI/PackageVersionSelector.png "Package version selector")  -->

Allows editing text files in a context of the selected profiles (local or remote)

As a good example one may think about editing Windows `hosts` file on the remote machines. There is an existing plugin for doing exactly that. 

**Namespace:** `Sifon.Shared.Forms.TextEditorDialog`

**Class type:** `TextEditor`

**Usage from meta-language:**
```
### $Content = new Sifon.Shared.Forms.TextEditorDialog.TextEditor::Read($Profile, "c:\Windows\System32\drivers\etc\hosts")
param($Content)
```


You may also want to copy and edit it in order to be able editing config files (without remembering their names and long paths), which is especially helpful on the remote machines.

<br/>

[<- Home](/ "Home")	

<hr>

<footer>
<p style="float:left; width: 20%;">
</p>
<p style="float:left; width: 60%; text-align:center;">Copyright &copy; <a href="https://blog.MartinMiles.net">Martin Miles</a>, 2020</p>
<p style="float:left; width: 20%;">
</p>
</footer>