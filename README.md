# TS3QueryLib.Net.Core
This library allows you to query team speak 3 servers using the query port.  All queries are implemented type safe and the library is written to work with .Net Core.

This library is work in progress. A lot of commands are missing, but the notifications are complete.

**List of Command-Implementation-State** (&#x2714; implemented - &#x2716; not implemented yet):


* &#x2716; help
* &#x2714; quit
* &#x2714; login
* &#x2714; logout
* &#x2714; version
* &#x2714; hostinfo
* &#x2714; instanceinfo
* &#x2714; instanceedit
* &#x2714; bindinglist
* &#x2714; use
* &#x2714; serverlist
* &#x2714; serveridgetbyport
* &#x2714; serverdelete
* &#x2714; servercreate
* &#x2714; serverstart
* &#x2714; serverstop
* &#x2714; serverprocessstop
* &#x2714; serverinfo
* &#x2714; serverrequestconnectioninfo
* &#x2714; servertemppasswordadd
* &#x2714; servertemppassworddel
* &#x2714; servertemppasswordlist
* &#x2716; serveredit
* &#x2714; servergrouplist
* &#x2714; servergroupadd
* &#x2714; servergroupdel
* &#x2714; servergroupcopy
* &#x2714; servergrouprename
* &#x2714; servergrouppermlist
* &#x2714; servergroupaddperm
* &#x2714; servergroupdelperm
* &#x2714; servergroupaddclient
* &#x2714; servergroupdelclient
* &#x2714; servergroupclientlist
* &#x2714; servergroupsbyclientid
* &#x2716; servergroupautoaddperm
* &#x2716; servergroupautodelperm
* &#x2714; serversnapshotcreate
* &#x2714; serversnapshotdeploy
* &#x2714; servernotifyregister
* &#x2714; servernotifyunregister
* &#x2714; sendtextmessage
* &#x2714; logview
* &#x2714; logadd
* &#x2714; gm
* &#x2714; channellist
* &#x2716; channelinfo
* &#x2714; channelfind
* &#x2714; channelmove
* &#x2714; channelcreate
* &#x2714; channeldelete
* &#x2714; channeledit
* &#x2714; channelgrouplist
* &#x2714; channelgroupadd
* &#x2714; channelgroupdel
* &#x2714; channelgroupcopy
* &#x2714; channelgrouprename
* &#x2714; channelgroupaddperm
* &#x2714; channelgrouppermlist
* &#x2714; channelgroupdelperm
* &#x2714; channelgroupclientlist
* &#x2714; setclientchannelgroup
* &#x2716; tokenadd
* &#x2716; tokendelete
* &#x2716; tokenlist
* &#x2716; tokenuse
* &#x2714; channelpermlist
* &#x2714; channeladdperm
* &#x2714; channeldelperm
* &#x2714; clientlist
* &#x2716; clientinfo
* &#x2714; clientfind
* &#x2714; clientedit
* &#x2714; clientdblist
* &#x2716; clientdbinfo
* &#x2714; clientdbfind
* &#x2714; clientdbedit
* &#x2714; clientdbdelete
* &#x2714; clientgetids
* &#x2714; clientgetdbidfromuid
* &#x2716; clientgetnamefromuid
* &#x2716; clientgetuidfromclid
* &#x2716; clientgetnamefromdbid
* &#x2714; clientsetserverquerylogin
* &#x2714; clientupdate
* &#x2714; clientmove
* &#x2714; clientkick
* &#x2714; clientpoke
* &#x2714; clientpermlist
* &#x2714; clientaddperm
* &#x2714; clientdelperm
* &#x2714; channelclientpermlist
* &#x2714; channelclientaddperm
* &#x2714; channelclientdelperm
* &#x2716; permissionlist
* &#x2716; permidgetbyname
* &#x2716; permoverview
* &#x2716; permget
* &#x2716; permfind
* &#x2714; permreset
* &#x2716; privilegekeylist
* &#x2714; privilegekeyadd
* &#x2714; privilegekeydelete
* &#x2714; privilegekeyuse
* &#x2716; messagelist
* &#x2714; messageadd
* &#x2714; messagedel
* &#x2716; messageget
* &#x2714; messageupdateflag
* &#x2716; complainlist
* &#x2714; complainadd
* &#x2714; complaindelall
* &#x2714; complaindel
* &#x2716; banclient
* &#x2716; banlist
* &#x2714; banadd
* &#x2714; bandel
* &#x2714; bandelall
* &#x2716; ftinitupload
* &#x2716; ftinitdownload
* &#x2716; ftlist
* &#x2716; ftgetfilelist
* &#x2716; ftgetfileinfo
* &#x2714; ftstop
* &#x2714; ftdeletefile
* &#x2714; ftcreatedir
* &#x2714; ftrenamefile
* &#x2716; customsearch
* &#x2716; custominfo
* &#x2716; whoami