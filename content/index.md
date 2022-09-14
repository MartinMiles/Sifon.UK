<link rel="apple-touch-icon" sizes="180x180" href="/apple-touch-icon.png">
<link rel="icon" type="image/png" sizes="32x32" href="/favicon-32x32.png">
<link rel="icon" type="image/png" sizes="16x16" href="/favicon-16x16.png">
<link rel="manifest" href="/site.webmanifest">


# <img src="content/img/icon.png" alt="Sifon" width="32" height="32" style="position: relative; top: -4px; left: -5px;" /> Sifon

A must-have tool for any Sitecore developer, to simplify most of your day-to-day DevOps activities

![Sifon](content/img/main_about.png "Sifon main interface") 


<br/>

## Downloads

Use this link to [download](content/download/Sifon_1.2.6.msi "download Sifon") your copy of Sifon. The source code is available at [GitHub](https://github.com/MartinMiles/Sifon "Sifon GitHub repository").

Those prefer installing with Chocolatey pakage manager can do: `choco install sifon -version 1.2.6`

You can learn what's new at the [Release notes](/content/docs/ReleaseNotes "Release notes") page.

<br/>

## Features

- functions with Sitecore versions 9.x and 10.x
- offers the best Sitecore installation tool ever: powerfull, intuitive, self-downloading, can install XP into a remote VM over network
- performs backup, clean, restore operations against selected Sitecore instance out-of-the-box with a nice GUI
- you can choose the above operations for webroot, xConnect, Identity Server, Horizon and Publishing Service sites (or them all)
- supports Sitecore Commerce of both 9.x and 10.x versions
- basic support for Sitecore in containers with Docker
- supports and correctly handles instances installations outside `inetpub\wwwroot` folder
- environment auto-detection: hostnames, bindings, installed Solr instances
- supports multiple instances on a host via creating and selecting profiles
- all the above can be done on remote VM via WinRM (WsMan) with remote profile
- supports plugins both written in PowerShell or compiled .NET libraries
- plugins can use API for downloading and consuming resources from Sitecore Developers Portal
- plugins are kept in hierarchical order and, in fact, may be crowdsourced
- respects Windows services: marketing automation, xConnect search indexer, processing engine and of course IIS
- install / uninstall any number of versions of Solr to local or remote machines

<br/>

## Getting started

Please take a look at this video before the first run, as it explains important bits, such as setting up a profile on the first run and what Profiles are. It also shows you how to obtain the latesy collection of plugins from a [public GitHib plugins repository](https://github.com/MartinMiles/Sifon.Plugins "public GitHib plugins repository"), how to configure containers for the first run of Sitecore 10 XP0 and also how to perform local and remote backups.

<p><iframe width="800" height="450" src="https://www.youtube.com/embed/dW7rF8CTAR4?feature=oembed" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe></p>

Here you may find even more [quick start videos and instructions](/content/docs/QuickStart "quick start videos and instructions")

<br/>

## Documentation

Please go through the documentation in order to benefint the max from using Sifon.

- [Quick start guide](/content/docs/QuickStart "Quick start guide")
- [Installing Sitecore with Sifon](/content/docs/Installer "Installing Sitecore with Sifon")
- [Understanding Profiles](/content/docs/Profiles "Understanding Profiles")
- [Backup and Restore](/content/docs/BackupRestore "Backup and Restore")
- [Public plugins library](/content/docs/PluginsLibrary "Public plugins library")
- [Creating own plugins](/content/docs/CreatingPlugin "Creating own plugins")
    - [Basics](/content/docs/BasicsPlugins "Basics")
    - [Labs & Demo](/content/docs/Labs "Labs & Demo")
    - [Meta](/content/docs/MetaSyntax "Basics")
    - [Sifon module](/content/docs/Module "Basics")
    - [Shared API](/content/docs/SharedAPI.md "Basics")
        - [Folder Browser](/content/docs/SharedAPI/FolderBrowser "Basics")
        - [Index Selector](/content/docs/SharedAPI/IndexSelector "Basics")
        - [Local File Picker](/content/docs/SharedAPI/LocalFilePicker "Basics")
        - [Package Version Selector](/content/docs/SharedAPI/PackageVersionSelector "Basics")
        - [Sitecore Version Selector](/content/docs/SharedAPI/SitecoreVersionSelector "Basics")
        - [Text Editor](/content/docs/SharedAPI/TextEditor "Text Editor")
        - [Sitecore Resources Downloader](/content/docs/SharedAPI/ResourcesDownloader "Sitecore Resources Downloader")
    - Walkthrough: Creating a plugin
    - [DLL Plugins](/content/docs/PluginsWithDLL "DLL Plugins")
- [Install/remove Solr](/content/docs/Solr "Install/remove Solr")
- [Containers suport](/content/docs/Containers "Containers suport")
- [Sitecore Commerce suport](/content/docs/Commerce "Sitecore Commerce suport")
- [Application settings](/content/docs/Settings "Application settings")
- [Release notes](/content/docs/ReleaseNotes "Release notes")
- [Provide feedback](/content/docs/Feedback "Release notes")
- [Known issues](/content/docs/KnownIssues "Known issues")

<br/>

## Impressive features to arrive later

- an ability to build own solutions images with Docker
- navigating interactively deep into containers
- mass content migration utility between environments
- restore Sitecore from backup into another clean machine
- anything else, suggested by you

<br/>

## Sponsor this project

It took me big efforts in order to reach this point with Sifon becoming mature and publically available. And that's only the beginning!

<iframe src="https://github.com/sponsors/MartinMiles/button" title="Sponsor Sifon" height="35" width="116" style="border: 0;"></iframe>

Please use the above button to support me developing Sifon further ahead with lots of challenging milestones to reach, including containers support, automating most of your daily routines and the ability of creating GUI for virtually anything one can do with Sitecore.


## License

Sifon is distributed under [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0 "Apache License version 2.0") license

