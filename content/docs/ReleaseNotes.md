# Release notes

Version **[1.3.5](../download/Sifon_1.3.5.msi "1.3.5")**

- added better support for XM topology
- extended and reworked profile (ie. `IsXM` parameter)
- minor bug fixes and improvements

Version **[1.3.4](../download/Sifon_1.3.4.msi "1.3.4")**

- added support for Sitecoef XP 10.3.1

Version **[1.3.3](../download/Sifon_1.3.3.msi "1.3.3")**

- added support for Sitecoef XP 10.3
- added support for Solr 8.11.2
- added download plugins for all XP 10.3 resources
- support for one-click Horizon installation on 10.3
- verified working well on Windows 11

Version **[1.2.6](../download/Sifon_1.2.6.msi "1.2.6")**

- prerequisites dialog got improved UX - no more confusing checkboxes
- fixes for Feedback form - now it successfully uses both channels to reach me with your suggestions
- few minor bugs fixed

Version **[1.2.5](../download/Sifon_1.2.5.msi "1.2.5")**

- supports Sitecore 10.2, supports Windows 11. Supports Sitecore 10.2 ON Windows 11!
- comprehensive testing has been done - many bugs fixed or refactored
- plugins were updated, consolidated with main functionality and each other
- it is now possible to mark a plugin with `### Requires Profile: false` to make it run even without active profile
- few features temporary suspended until got improved
- lots of new plugins including installers for latest Horizon, SXA, Publishing Service 6.0 etc
- added support for Solr 8.8.2 and fixed a minor bug in Solr (un)installation script, making it genuinely universal
- added syntax to present (double)clickable URLs right in the output to help users with supporting info
- added `Get-SitecoreVersion` function that returns either object or string with current XP or XM release version 
- added `Verify-NetCoreHosting` function to ensure minimum required .NET Core version (passed as param) presents on a target system
- since all the SQL Server activity goes through `SqlServer` PowerShell module (opposed to `SQLPS`) - it is now added to Sifon prerequisites

Version **[1.2.4](../download/Sifon_1.2.4.msi "1.2.4")**

- can now install XP0 both locally and into a remote machine/VM over a networn
- installer downloads, unpacks, configures and runs all the necessary resources for you in the background
- reasonable default settings help one-click confuguring installation parameters
- few new plugins and Shared UI support for them
- new 'Reset All Existing Settings' menu now allows removing Settings folder along with profiles to the Sifon initial state

Version **[1.2.3](../download/Sifon_1.2.3.msi "1.2.3")**

- Sifon can now install its own openid client into Identity Serve and obtain acess token from it
- Sifon returns to chocolatey package repository, making it easier for you to install it from command prompt
- fixed bugs with incorrect TabIndex order on forms with multiple groupboxes
- no more credentials required for downloading Sitecore resources, also removed from dependant plugins
- shared API forms got helpful tooltips
- minor other bug fixes and stability improvements


Version **[1.2.2](../download/Sifon_1.2.2.msi "1.2.2")**

- added a switch to Settings for choosing the way to download from Sitecore: either by using an old approach or from GEO-distributed CDNs (default value)
- this version features cancellation of credentials requirement policy by Sitecore: no more need to have certified developers profile to download assets
- built-in Get-SifonPlugins now prevent user from accidental deletion of the pluugins repository, asking if it was intended to update the plugin scripts
- download Sitecore resources now has "resume downloading" option - completing unfinished items if download broak half the way

Version **[1.2.1](../download/Sifon_1.2.1.msi "1.2.1")**

- added Shared UI for Sitecore Resources Downloader
- counterparty plugins created for Sitecore Resources Downloader and added into `v1.2.1` branch of [Sifon.Plugins](https://github.com/MartinMiles/Sifon.Plugins "Sifon.Plugins") repository
- icons added to missing forms from some of Shared UI along with other minor UI improvements


Version **[1.2.0](../download/Sifon_1.2.0.msi "1.2.0")**

- this version contains **breaking changes**
- versioning has changed, that affects all the plugins and check updates features 
- runtime .NET Framework has been updated to the latest version 4.8, affecting all the satellite solutions
- new main feature: Solr installer / uninstaller
- minor bugs and improvements fixed in Sifon module and Connectivity tab of profile editor and asynchronousness
- there's an new option for having a custom plugins folder that is merged into Sifon.Plugins folder on a runtime
- new shared UI component: Text Editor, allows editing files from your plugins either on local or mote machines (i.e. remote hosts file)
- a satellite repository [Sifon.Packages](https://github.com/MartinMiles/Sifon.Packages "Sifon.Packages") added storing NuGet libraries shared across Sifon family


Version **[1.01](../download/Sifon_1.01.msi "1.01")**

- this version focuses on the fixes and improvements found at v1.00
- first-run experience reworked for becoming more transparent; first-run messages rewritten for more easier instructions
- new shared control added for listing and selection of Sitecore instance indexes
- reworked API around creating more user-friendly UI
- new module functions added for finding and rebuilding indexes and showing output messages
- added new prerequisite check and installation for .NET Core SDK
- your plugins can now output empty lines by outputting '.' (string dot character) - spacing allow creating better UI
- the counterpart public community plugins repository has updates most of the script for version 1.01
- user can now also specify a custom plugins repository of an own choice from *Application Setting* menu and its branch


Version **[1.00](../download/Sifon_1.00.msi "1.00")**

- this is **The Release** public version of Sifon and the product now becomes official
- from this version onwards Sifon is shipped in two ways: Windows (msi) installer and Chocolatey
- a massive pre-release refactoring done, followed by decent regression testing
- new UI component helps making installer scripts: now your installer can show UI for choosing version (i.e. for SXA), works on both local and remote
- new meta-syntax added to enforce plugins execute on local context regardless of current profile
- first run experience reworked, offering prerequisites check and install before first run
- more friendly first run made for those not having local Sitecore who's only looking for Docker stuff
- containers reworked to be more universal and another new container demo added ('Lighthouse') for a quick start
- new about screen with credits box, Feedback form that sends author instant message
- new setting that permits Sifon sending anonymous error logs - please help making Sifon better by agreeing to
- new feature to check if there is a new version available for download from the Sifon website
- the application and its dialogs got nice icons, including an icon for desktop with 'run as Administrator' checked
- many other small, but very annoying bugs and issues got fixed


Version **0.99**

- added new version check feature from within About menu
- added collecting feedbacks from users from within About menu
- added feature requesting sending anonymous error logs to developer for improving the product
- first run experience changed a lot: prerequisites presence is checked, and they are offered to install, if needed
- improved scripting with Sifon; all scripts reworked into auto installed Sifon module from Core folder
- new Sifon icons added instead of default placeholders, including application icon and About image
- dll naming contains breaking changes and many of the code been moved around for better accountability
- plenty of bugs and unfinished stuff got fixed and completed; source code also cleaned-up
- script meta syntax added to make the following magic happen:
    1. now your scripts can perform user interaction (i.e. requesting license, showing a folder selector dialog) even with the remote profile
    2. compatibility clause ensures minimal version of Sifon your script will be presented with, if less script isn't shown in the menu


Version **0.98**

- first basic option for containers with Sitecore 10.0 has added, including easy clone and setup, profile switching
- container scripts now show under Containers menu, rather than under Plugins - 
- container scripts added for: set up Hyper-V and containers support, pulling the code, building and running Sitecore in Docker
- some plugins and Sifon in general tested against the remote instance and numerous issues identified and fixed
- many existing plugins adjusted, thus only working with the latest (0.98 or newer) version of Sifon
- minor bugs on running first time and initial configuration
- added meta code supports to plugins scripts to comply with remote execution where UI isn't available: 
    1. executing GUI user input and automatically pass it to either local or remote script with a variable of choice
    2. specifying dependencies for those plugins that aren't just one script file: associated files are also copied to remote


Version **0.97**

- now supports and correctly handles instances installations outside `inetpub\wwwroot` folder
- this is mostly stabilized release of all previous features, critically reviewed and corrected
- on a first run there is no default profile set up for you (previously was: habitat), now truly new user experience
- improvements within external plugins; also a new plugin to install SPE 6.1.1 with Remoting enabled in one click
- now Sifon module has two functions for package installation: 
    1. `Install-SitecorePackage` - universal and slow, creating temporal page (to get into Context) with module installation logic
    2. `Install-SitecorePackageUsingRemoting` - new, reliable and fast, but requires SPE with Remoting enabled on target


Version **0.96**

- a PowerShell module for Sifon has introduced with commonly called functions
- now Sifon is aware of Horizon and Publishing Service and carefully does backup, cleanup and restore for those
- new "Settings" menu with an option to add your Sitecore developer's credentials
- a feature to test credentials and store and pass them into a script already in an encrypted way
- now Sifon is capable of downloading Sitecore resources in one click from any script via a module function
- this module is auto-installed into a system PowerShell folder on the first run
- profile editor now also asks for Sitecore instance admin username and password
- folder rename: Core scripts now went under PowerShell/Core along with Module folder
- added more mute syntaxes for: warnings, errors and for muting nested progress streams that break yours
- plenty of minor bugfixes and improvements


Version **0.95**

- new plugin system allows one-click plugins pull and setup from public GitHub repository
- plugins folder has been renamed to address the above change
- shared API got new LocalFilePicker control
- scripts plugins output has reworked to better presentation, also eliminating whitespaces
- new output muting / unmuting syntax to suppress uncontrolled "output verbose abuse"


Version **0.94**

- now supports Sitecore 10.0 and Commerce 10.0
- improved system services operations for stability
- adjusted Commerce database identification due to 10.0 changes
- minor bugfixes done


Version **0.93**

- supported Sitecore versions selector now available from Shared API
- restore of SQL databases now occurs in "relocate" mode to avoid broken paths
- minor bugfixes in the profile editor


Version **0.92** and older

- this version brings 'large and heavy' code refactoring from PoC into a more-less working product
- because of that some instability may occur, needed intensive regression testing
- most of the features become mature: local and remote, support for XC, plugins and custom scripts, full backup-restore cycle

<br/><br/>
[<- Home](/ "Home")	
