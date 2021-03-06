<Query Kind="Program">
  <Reference>F:\Projects\Common\lib\AgileBet.SBK.Integration.Common.dll</Reference>
  <Reference>&lt;ProgramFilesX64&gt;\Microsoft SDKs\Azure\.NET SDK\v2.9\bin\plugins\Diagnostics\Newtonsoft.Json.dll</Reference>
  <Namespace>Newtonsoft.Json</Namespace>
</Query>

void Main()
{
	#region data
	var data = @"
 [
		[
			""2019-04-17T10:00:00"",
			67,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-17T10:00:00"",
			63,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-17T10:00:00"",
			34,
			1,
			""dotblogs.com.tw"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T10:00:00"",
			32,
			1,
			""mintty"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T10:00:00"",
			31,
			1,
			""dinbendon.net"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T10:00:00"",
			31,
			1,
			""autodeploy"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T10:00:00"",
			30,
			1,
			""Mail"",
			""Email"",
			0
		],
		[
			""2019-04-17T10:00:00"",
			21,
			1,
			""rescuetime.com"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T10:00:00"",
			17,
			1,
			""blog.miniasp.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T10:00:00"",
			14,
			1,
			""cultizm.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T10:00:00"",
			12,
			1,
			""term.ptt.cc"",
			""bbs"",
			-2
		],
		[
			""2019-04-17T10:00:00"",
			11,
			1,
			""RescueTime"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T10:00:00"",
			8,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-17T10:00:00"",
			8,
			1,
			""Desktop Window Manager"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T10:00:00"",
			7,
			1,
			""172.16.41.55"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T10:00:00"",
			6,
			1,
			""q-dir"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T10:00:00"",
			6,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T10:00:00"",
			3,
			1,
			""system idle process"",
			""Other"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			659,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			342,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			314,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			247,
			1,
			""social.msdn.microsoft.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			180,
			1,
			""MS Mgmt Console"",
			""Systems Operations"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			167,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			141,
			1,
			""cnblogs.com"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-17T11:00:00"",
			133,
			1,
			""blog.csdn.net"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-17T11:00:00"",
			99,
			1,
			""itread01.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			90,
			1,
			""q-dir"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			80,
			1,
			""NotePad++"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			78,
			1,
			""sechealthui"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			73,
			1,
			""likewaylai.blogspot.com"",
			""General Business"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			70,
			1,
			""gvim"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			52,
			1,
			""blog.miniasp.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			48,
			1,
			""dotblogs.com.tw"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			46,
			1,
			""reneelab.net"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			41,
			1,
			""azurefromthetrenches.com"",
			""Engineering \u0026 Technology"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			38,
			1,
			""boostlog.io"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			36,
			1,
			""archive.codeplex.com"",
			""Engineering \u0026 Technology"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			36,
			1,
			""my.oschina.net"",
			""Engineering \u0026 Technology"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			34,
			1,
			""systemsettings"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			32,
			1,
			""jira.ict888.net:8080"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			29,
			1,
			""huaidan.org"",
			""Engineering \u0026 Technology"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			29,
			1,
			""blogs.msdn.microsoft.com"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			25,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			23,
			1,
			""docs.microsoft.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			22,
			1,
			""beej-zhtw.netdpi.net"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			18,
			1,
			""sourcetree"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			17,
			1,
			""fdlly.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			17,
			1,
			""experts-exchange.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			16,
			1,
			""Skype"",
			""Voice Chat"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			16,
			1,
			""github.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			15,
			1,
			""guidingtech.com"",
			""Engineering \u0026 Technology"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			15,
			1,
			""blog.okbase.net"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			14,
			1,
			""codeday.me"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			13,
			1,
			""openwith"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			13,
			1,
			""albert-yu.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			11,
			1,
			""ctolib.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			10,
			1,
			""Notepad"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			8,
			1,
			""bbs.csdn.net"",
			""Engineering \u0026 Technology"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			6,
			1,
			""shafqatahmed.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			5,
			1,
			""host"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			5,
			1,
			""vimrun"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T11:00:00"",
			5,
			1,
			""searchui"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T11:00:00"",
			3,
			1,
			""autodeploy"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T11:00:00"",
			1,
			1,
			""system idle process"",
			""Other"",
			0
		],
		[
			""2019-04-17T12:00:00"",
			912,
			1,
			""term.ptt.cc"",
			""bbs"",
			-2
		],
		[
			""2019-04-17T12:00:00"",
			511,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T12:00:00"",
			356,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-17T12:00:00"",
			241,
			1,
			""Skype"",
			""Voice Chat"",
			1
		],
		[
			""2019-04-17T12:00:00"",
			156,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T12:00:00"",
			148,
			1,
			""coco01.today"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T12:00:00"",
			131,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-17T12:00:00"",
			103,
			1,
			""youtube.com"",
			""Video"",
			-2
		],
		[
			""2019-04-17T12:00:00"",
			86,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T12:00:00"",
			60,
			1,
			""rescuetime.com"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T12:00:00"",
			57,
			1,
			""wiki.komica.org"",
			""Games"",
			-2
		],
		[
			""2019-04-17T12:00:00"",
			36,
			1,
			""quora.com"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-04-17T12:00:00"",
			23,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-17T12:00:00"",
			21,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T12:00:00"",
			18,
			1,
			""test.com"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-17T12:00:00"",
			16,
			1,
			""t-cat.com.tw"",
			""General Business"",
			2
		],
		[
			""2019-04-17T12:00:00"",
			15,
			1,
			""s.taobao.com"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-17T12:00:00"",
			14,
			1,
			""world.taobao.com"",
			""General Business"",
			2
		],
		[
			""2019-04-17T12:00:00"",
			13,
			1,
			""Mail"",
			""Email"",
			0
		],
		[
			""2019-04-17T12:00:00"",
			12,
			1,
			""buyandship.com.tw"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T12:00:00"",
			11,
			1,
			""buyertrade.taobao.com"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-17T12:00:00"",
			10,
			1,
			""codeproject.com"",
			""Engineering \u0026 Technology"",
			1
		],
		[
			""2019-04-17T12:00:00"",
			9,
			1,
			""forum.gamer.com.tw"",
			""Games"",
			-2
		],
		[
			""2019-04-17T12:00:00"",
			9,
			1,
			""detail.i56.taobao.com"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-17T12:00:00"",
			8,
			1,
			""sourcetree"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T12:00:00"",
			6,
			1,
			""demo.com"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-17T12:00:00"",
			5,
			1,
			""dotblogs.com.tw"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T12:00:00"",
			1,
			1,
			""system idle process"",
			""Other"",
			0
		],
		[
			""2019-04-17T13:00:00"",
			502,
			1,
			""term.ptt.cc"",
			""bbs"",
			-2
		],
		[
			""2019-04-17T13:00:00"",
			496,
			1,
			""reddit.com"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-17T13:00:00"",
			493,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T13:00:00"",
			360,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-17T13:00:00"",
			123,
			1,
			""Skype"",
			""Voice Chat"",
			1
		],
		[
			""2019-04-17T13:00:00"",
			81,
			1,
			""help.rescuetime.com"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-04-17T13:00:00"",
			81,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-17T13:00:00"",
			52,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T13:00:00"",
			35,
			1,
			""github.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T13:00:00"",
			30,
			1,
			""applic"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T13:00:00"",
			27,
			1,
			""restrict_thingy"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T13:00:00"",
			17,
			1,
			""q-dir"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T13:00:00"",
			14,
			1,
			""instagram.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-17T13:00:00"",
			11,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T13:00:00"",
			11,
			1,
			""trackings.post.japanpost.jp"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-17T13:00:00"",
			9,
			1,
			""buyee.jp"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-17T13:00:00"",
			9,
			1,
			""facebook.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-17T13:00:00"",
			9,
			1,
			""buyandship.com.tw"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T13:00:00"",
			7,
			1,
			""timer"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T13:00:00"",
			4,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-17T13:00:00"",
			4,
			1,
			""autodeploy"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T13:00:00"",
			2,
			1,
			""NotePad++"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			766,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			437,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			414,
			1,
			""gvim"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			367,
			1,
			""datagrip64"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			348,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-17T14:00:00"",
			262,
			1,
			""localhost:8899"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			129,
			1,
			""adcontrol.sb.com"",
			""Quality Assurance"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			114,
			1,
			""github.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			103,
			1,
			""q-dir"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T14:00:00"",
			92,
			1,
			""rescuetime.com"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			81,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			78,
			1,
			""applic"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T14:00:00"",
			64,
			1,
			""developer.chrome.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			46,
			1,
			""jsonbuddyapp"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			34,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T14:00:00"",
			32,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T14:00:00"",
			31,
			1,
			""blog.csdn.net"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-17T14:00:00"",
			31,
			1,
			""itread01.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T14:00:00"",
			28,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-17T14:00:00"",
			22,
			1,
			""docs.microsoft.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			20,
			1,
			""superuser.com"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-17T14:00:00"",
			18,
			1,
			""NotePad++"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			17,
			1,
			""dev.to"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-04-17T14:00:00"",
			13,
			1,
			""quora.com"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-04-17T14:00:00"",
			8,
			1,
			""inherit"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T14:00:00"",
			5,
			1,
			""Skype"",
			""Voice Chat"",
			1
		],
		[
			""2019-04-17T14:00:00"",
			2,
			1,
			""vimrun"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T14:00:00"",
			1,
			1,
			""system idle process"",
			""Other"",
			0
		],
		[
			""2019-04-17T15:00:00"",
			1004,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			675,
			1,
			""gvim"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			382,
			1,
			""localhost:8899"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			328,
			1,
			""datagrip64"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			253,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			194,
			1,
			""adcontrol.sb.com"",
			""Quality Assurance"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			144,
			1,
			""q-dir"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T15:00:00"",
			105,
			1,
			""jira.ict888.net:8080"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			46,
			1,
			""rescuetime.com"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			41,
			1,
			""systemsettings"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T15:00:00"",
			41,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-17T15:00:00"",
			39,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T15:00:00"",
			36,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T15:00:00"",
			26,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			19,
			1,
			""github.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			19,
			1,
			""Task Manager"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T15:00:00"",
			15,
			1,
			""dllhost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T15:00:00"",
			13,
			1,
			""RescueTime"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			11,
			1,
			""rdo"",
			""Operations"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			10,
			1,
			""sourcetree"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T15:00:00"",
			9,
			1,
			""Desktop Window Manager"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T15:00:00"",
			6,
			1,
			""vi.stackexchange.com"",
			""Engineering \u0026 Technology"",
			1
		],
		[
			""2019-04-17T15:00:00"",
			4,
			1,
			""searchui"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T15:00:00"",
			2,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T16:00:00"",
			1433,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T16:00:00"",
			269,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-17T16:00:00"",
			126,
			1,
			""datagrip64"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T16:00:00"",
			95,
			1,
			""jira.ict888.net:8080"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T16:00:00"",
			86,
			1,
			""linqpad"",
			""Data Modeling \u0026 Analysis"",
			2
		],
		[
			""2019-04-17T16:00:00"",
			69,
			1,
			""localhost:8899"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T16:00:00"",
			60,
			1,
			""sourcetree"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T16:00:00"",
			24,
			1,
			""buyandship.com.tw"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T16:00:00"",
			23,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T16:00:00"",
			20,
			1,
			""adcontrol.sb.com"",
			""Quality Assurance"",
			2
		],
		[
			""2019-04-17T16:00:00"",
			14,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T16:00:00"",
			12,
			1,
			""picpick"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T16:00:00"",
			11,
			1,
			""t-cat.com.tw"",
			""General Business"",
			2
		],
		[
			""2019-04-17T16:00:00"",
			9,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T16:00:00"",
			5,
			1,
			""gvim"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T16:00:00"",
			2,
			1,
			""autodeploy"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T16:00:00"",
			2,
			1,
			""iisexpresstray"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			1465,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			422,
			1,
			""172.16.45.189:8080"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			238,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			197,
			1,
			""sourcetree"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			166,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			141,
			1,
			""jsonbuddyapp"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			131,
			1,
			""rescuetime.com"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			113,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T17:00:00"",
			104,
			1,
			""localhost:8899"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			102,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-17T17:00:00"",
			95,
			1,
			""blog.darkthread.net"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T17:00:00"",
			72,
			1,
			""limitedcode.blogspot.com"",
			""General Business"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			58,
			1,
			""linqpad"",
			""Data Modeling \u0026 Analysis"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			56,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-17T17:00:00"",
			49,
			1,
			""cnblogs.com"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-17T17:00:00"",
			42,
			1,
			""kdiff3"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			25,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T17:00:00"",
			22,
			1,
			""Skype"",
			""Voice Chat"",
			1
		],
		[
			""2019-04-17T17:00:00"",
			14,
			1,
			""adcontrol.sb.com"",
			""Quality Assurance"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			11,
			1,
			""mintty"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T17:00:00"",
			11,
			1,
			""Mail"",
			""Email"",
			0
		],
		[
			""2019-04-17T17:00:00"",
			9,
			1,
			""cultizm.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T17:00:00"",
			7,
			1,
			""c:"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T17:00:00"",
			5,
			1,
			""system idle process"",
			""Other"",
			0
		],
		[
			""2019-04-17T17:00:00"",
			4,
			1,
			""blog.wahahajk.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T17:00:00"",
			4,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T17:00:00"",
			2,
			1,
			""searchui"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T18:00:00"",
			2598,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T18:00:00"",
			521,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T18:00:00"",
			111,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-17T18:00:00"",
			85,
			1,
			""jsonbuddyapp"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T18:00:00"",
			48,
			1,
			""dotblogs.com.tw"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T18:00:00"",
			41,
			1,
			""docs.microsoft.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T18:00:00"",
			34,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-17T18:00:00"",
			33,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T18:00:00"",
			26,
			1,
			""json2csharp.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T18:00:00"",
			24,
			1,
			""forums.asp.net"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T18:00:00"",
			16,
			1,
			""jsonutils.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T18:00:00"",
			15,
			1,
			""linqpad"",
			""Data Modeling \u0026 Analysis"",
			2
		],
		[
			""2019-04-17T18:00:00"",
			12,
			1,
			""rescuetime.com"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T18:00:00"",
			11,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T18:00:00"",
			3,
			1,
			""jsonconvert.deserializeobject"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T19:00:00"",
			571,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T19:00:00"",
			222,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T19:00:00"",
			197,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T19:00:00"",
			52,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-17T19:00:00"",
			46,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-17T19:00:00"",
			19,
			1,
			""sourcetree"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T19:00:00"",
			19,
			1,
			""systemsettings"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T19:00:00"",
			12,
			1,
			""jsonbuddyapp"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-17T19:00:00"",
			11,
			1,
			""newtonsoft.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T19:00:00"",
			7,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T19:00:00"",
			5,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-17T19:00:00"",
			2,
			1,
			""RescueTime"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T20:00:00"",
			1026,
			1,
			""netflix.com"",
			""Video"",
			-2
		],
		[
			""2019-04-17T20:00:00"",
			644,
			1,
			""ptt.cc"",
			""bbs"",
			-2
		],
		[
			""2019-04-17T20:00:00"",
			428,
			1,
			""youtube.com"",
			""Video"",
			-2
		],
		[
			""2019-04-17T20:00:00"",
			295,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-17T20:00:00"",
			277,
			1,
			""mobile01.com"",
			""Science \u0026 Technology"",
			-1
		],
		[
			""2019-04-17T20:00:00"",
			88,
			1,
			""rtkngui64"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T20:00:00"",
			53,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T20:00:00"",
			37,
			1,
			""bbs.fiio.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T20:00:00"",
			23,
			1,
			""searchui"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T20:00:00"",
			21,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T20:00:00"",
			12,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-17T20:00:00"",
			11,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-17T20:00:00"",
			7,
			1,
			""thunder"",
			""General Entertainment"",
			-2
		],
		[
			""2019-04-17T20:00:00"",
			5,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T20:00:00"",
			5,
			1,
			""gordonntw.blogspot.com"",
			""General Business"",
			2
		],
		[
			""2019-04-17T20:00:00"",
			3,
			1,
			""newtab"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T20:00:00"",
			1,
			1,
			""systemsettings"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T21:00:00"",
			512,
			1,
			""iamchucky.github.io"",
			""bbs"",
			-2
		],
		[
			""2019-04-17T21:00:00"",
			312,
			1,
			""ptt.cc"",
			""bbs"",
			-2
		],
		[
			""2019-04-17T21:00:00"",
			220,
			1,
			""thunder"",
			""General Entertainment"",
			-2
		],
		[
			""2019-04-17T21:00:00"",
			142,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-17T21:00:00"",
			113,
			1,
			""github.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T21:00:00"",
			47,
			1,
			""facebook.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-17T21:00:00"",
			46,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-17T21:00:00"",
			38,
			1,
			""instagram.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-17T21:00:00"",
			34,
			1,
			""photos.google.com"",
			""Photos"",
			-2
		],
		[
			""2019-04-17T21:00:00"",
			29,
			1,
			""system idle process"",
			""Other"",
			0
		],
		[
			""2019-04-17T21:00:00"",
			20,
			1,
			""newtab"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T21:00:00"",
			19,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T21:00:00"",
			18,
			1,
			""ettoday.net"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-17T21:00:00"",
			10,
			1,
			""youtube.com"",
			""Video"",
			-2
		],
		[
			""2019-04-17T21:00:00"",
			9,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-17T21:00:00"",
			8,
			1,
			""tw.appledaily.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T21:00:00"",
			7,
			1,
			""gameapps.hk"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T21:00:00"",
			7,
			1,
			""auth.omoplanet.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T21:00:00"",
			2,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T22:00:00"",
			20,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-17T22:00:00"",
			3,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-17T22:00:00"",
			2,
			1,
			""rtkngui64"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T23:00:00"",
			520,
			1,
			""24h.pchome.com.tw"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-17T23:00:00"",
			403,
			1,
			""OneNote"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-04-17T23:00:00"",
			379,
			1,
			""ecshweb.pchome.com.tw"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-17T23:00:00"",
			325,
			1,
			""rescuetime.com"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T23:00:00"",
			267,
			1,
			""iamchucky.github.io"",
			""bbs"",
			-2
		],
		[
			""2019-04-17T23:00:00"",
			244,
			1,
			""newtab"",
			""Browsers"",
			0
		],
		[
			""2019-04-17T23:00:00"",
			166,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-17T23:00:00"",
			76,
			1,
			""pcstore.com.tw"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-17T23:00:00"",
			58,
			1,
			""pdrstyleagent"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T23:00:00"",
			56,
			1,
			""mall.pchome.com.tw"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-17T23:00:00"",
			47,
			1,
			""facebook.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-17T23:00:00"",
			25,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T23:00:00"",
			15,
			1,
			""picpick"",
			""Intelligence"",
			2
		],
		[
			""2019-04-17T23:00:00"",
			14,
			1,
			""github.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-17T23:00:00"",
			13,
			1,
			""instagram.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-17T23:00:00"",
			8,
			1,
			""mobile01.com"",
			""Science \u0026 Technology"",
			-1
		],
		[
			""2019-04-17T23:00:00"",
			6,
			1,
			""ecssl.pchome.com.tw"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-17T23:00:00"",
			5,
			1,
			""shopping.pchome.com.tw"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-17T23:00:00"",
			5,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T23:00:00"",
			4,
			1,
			""pchome.com.tw"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-17T23:00:00"",
			3,
			1,
			""pchomeskype.com.tw"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-17T23:00:00"",
			3,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-17T23:00:00"",
			2,
			1,
			""searchui"",
			""General Utilities"",
			1
		],
		[
			""2019-04-17T23:00:00"",
			1,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-17T23:00:00"",
			1,
			1,
			""vi000246.github.io"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T00:00:00"",
			626,
			1,
			""24h.pchome.com.tw"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-18T00:00:00"",
			244,
			1,
			""ecshweb.pchome.com.tw"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-18T00:00:00"",
			122,
			1,
			""ecssl.pchome.com.tw"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-18T00:00:00"",
			91,
			1,
			""iamchucky.github.io"",
			""bbs"",
			-2
		],
		[
			""2019-04-18T00:00:00"",
			74,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-18T00:00:00"",
			68,
			1,
			""mall.pchome.com.tw"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-18T00:00:00"",
			46,
			1,
			""rtkngui64"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T00:00:00"",
			44,
			1,
			""item.taobao.com"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-18T00:00:00"",
			35,
			1,
			""world.taobao.com"",
			""General Business"",
			2
		],
		[
			""2019-04-18T00:00:00"",
			26,
			1,
			""global.rakuten.com"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-18T00:00:00"",
			25,
			1,
			""s.taobao.com"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-18T00:00:00"",
			25,
			1,
			""facebook.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-18T00:00:00"",
			22,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-18T00:00:00"",
			16,
			1,
			""instagram.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-18T00:00:00"",
			12,
			1,
			""pay.google.com"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-18T00:00:00"",
			8,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T00:00:00"",
			6,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-18T00:00:00"",
			6,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T00:00:00"",
			4,
			1,
			""newtab"",
			""Browsers"",
			0
		],
		[
			""2019-04-18T00:00:00"",
			2,
			1,
			""rescuetime.com"",
			""Intelligence"",
			2
		],
		[
			""2019-04-18T00:00:00"",
			2,
			1,
			""books.com.tw"",
			""Search"",
			0
		],
		[
			""2019-04-18T00:00:00"",
			2,
			1,
			""buyertrade.taobao.com"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-18T00:00:00"",
			2,
			1,
			""system idle process"",
			""Other"",
			0
		],
		[
			""2019-04-18T00:00:00"",
			1,
			1,
			""keep.google.com"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-04-18T00:00:00"",
			1,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-18T01:00:00"",
			796,
			1,
			""iamchucky.github.io"",
			""bbs"",
			-2
		],
		[
			""2019-04-18T01:00:00"",
			211,
			1,
			""youtube.com"",
			""Video"",
			-2
		],
		[
			""2019-04-18T01:00:00"",
			192,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-18T01:00:00"",
			179,
			1,
			""rescuetime.com"",
			""Intelligence"",
			2
		],
		[
			""2019-04-18T01:00:00"",
			129,
			1,
			""facebook.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-18T01:00:00"",
			127,
			1,
			""topnews8.com"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T01:00:00"",
			105,
			1,
			""upc"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T01:00:00"",
			78,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-18T01:00:00"",
			71,
			1,
			""stars.udn.com"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-18T01:00:00"",
			59,
			1,
			""store.ubi.com"",
			""Games"",
			-2
		],
		[
			""2019-04-18T01:00:00"",
			56,
			1,
			""Gmail"",
			""Email"",
			0
		],
		[
			""2019-04-18T01:00:00"",
			32,
			1,
			""connect.ubi.com"",
			""Games"",
			-2
		],
		[
			""2019-04-18T01:00:00"",
			25,
			1,
			""ptt.cc"",
			""bbs"",
			-2
		],
		[
			""2019-04-18T01:00:00"",
			24,
			1,
			""google.com/calendar"",
			""Calendars"",
			0
		],
		[
			""2019-04-18T01:00:00"",
			23,
			1,
			""instagram.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-18T01:00:00"",
			19,
			1,
			""foundi.info"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T01:00:00"",
			12,
			1,
			""tv543.org"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T01:00:00"",
			11,
			1,
			""newtab"",
			""Browsers"",
			0
		],
		[
			""2019-04-18T01:00:00"",
			9,
			1,
			""zh.wikipedia.org"",
			""Search"",
			0
		],
		[
			""2019-04-18T01:00:00"",
			8,
			1,
			""searchui"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T01:00:00"",
			5,
			1,
			""thunder"",
			""General Entertainment"",
			-2
		],
		[
			""2019-04-18T01:00:00"",
			4,
			1,
			""register.ubisoft.com"",
			""Games"",
			-2
		],
		[
			""2019-04-18T01:00:00"",
			3,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T01:00:00"",
			1,
			1,
			""goo.gl"",
			""Internet Utilities"",
			1
		],
		[
			""2019-04-18T08:00:00"",
			809,
			1,
			""iamchucky.github.io"",
			""bbs"",
			-2
		],
		[
			""2019-04-18T08:00:00"",
			95,
			1,
			""rescuetime.com"",
			""Intelligence"",
			2
		],
		[
			""2019-04-18T08:00:00"",
			56,
			1,
			""instagram.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-18T08:00:00"",
			35,
			1,
			""zh.wikipedia.org"",
			""Search"",
			0
		],
		[
			""2019-04-18T08:00:00"",
			23,
			1,
			""newtab"",
			""Browsers"",
			0
		],
		[
			""2019-04-18T08:00:00"",
			17,
			1,
			""facebook.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-18T08:00:00"",
			15,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-18T08:00:00"",
			14,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-18T08:00:00"",
			13,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T08:00:00"",
			8,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T08:00:00"",
			6,
			1,
			""thunder"",
			""General Entertainment"",
			-2
		],
		[
			""2019-04-18T08:00:00"",
			3,
			1,
			""system idle process"",
			""Other"",
			0
		],
		[
			""2019-04-18T08:00:00"",
			3,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-18T08:00:00"",
			2,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-18T09:00:00"",
			152,
			1,
			""iamchucky.github.io"",
			""bbs"",
			-2
		],
		[
			""2019-04-18T09:00:00"",
			51,
			1,
			""facebook.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-18T09:00:00"",
			49,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-18T09:00:00"",
			37,
			1,
			""system idle process"",
			""Other"",
			0
		],
		[
			""2019-04-18T09:00:00"",
			35,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T09:00:00"",
			23,
			1,
			""vogue.com.tw"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-18T09:00:00"",
			4,
			1,
			""newtab"",
			""Browsers"",
			0
		],
		[
			""2019-04-18T09:00:00"",
			3,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T10:00:00"",
			2435,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-18T10:00:00"",
			413,
			1,
			""dotblogs.com.tw"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T10:00:00"",
			141,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T10:00:00"",
			49,
			1,
			""jsonbin.io"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T10:00:00"",
			48,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-18T10:00:00"",
			39,
			1,
			""adcontrol.sb.com"",
			""Quality Assurance"",
			2
		],
		[
			""2019-04-18T10:00:00"",
			36,
			1,
			""blog.techbridge.cc"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T10:00:00"",
			30,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-18T10:00:00"",
			26,
			1,
			""dinbendon.net"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T10:00:00"",
			23,
			1,
			""sourcetree"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T10:00:00"",
			17,
			1,
			""Mail"",
			""Email"",
			0
		],
		[
			""2019-04-18T10:00:00"",
			9,
			1,
			""q-dir"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T10:00:00"",
			8,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-18T10:00:00"",
			6,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T10:00:00"",
			5,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T10:00:00"",
			2,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-18T10:00:00"",
			1,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-18T11:00:00"",
			1196,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-18T11:00:00"",
			1156,
			1,
			""Skype"",
			""Voice Chat"",
			1
		],
		[
			""2019-04-18T11:00:00"",
			127,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-18T11:00:00"",
			86,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-18T11:00:00"",
			72,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T11:00:00"",
			49,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-18T11:00:00"",
			28,
			1,
			""github.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T11:00:00"",
			22,
			1,
			""docs.microsoft.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T11:00:00"",
			18,
			1,
			""csharp2json.io"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T11:00:00"",
			15,
			1,
			""icy810406.pixnet.net"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-18T11:00:00"",
			10,
			1,
			""disp.cc"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-18T11:00:00"",
			4,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T11:00:00"",
			3,
			1,
			""wome"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T11:00:00"",
			1,
			1,
			""system idle process"",
			""Other"",
			0
		],
		[
			""2019-04-18T12:00:00"",
			1073,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-18T12:00:00"",
			877,
			1,
			""term.ptt.cc"",
			""bbs"",
			-2
		],
		[
			""2019-04-18T12:00:00"",
			138,
			1,
			""facebook.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-18T12:00:00"",
			115,
			1,
			""t-cat.com.tw"",
			""General Business"",
			2
		],
		[
			""2019-04-18T12:00:00"",
			106,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-18T12:00:00"",
			77,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-18T12:00:00"",
			66,
			1,
			""dinbendon.net"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T12:00:00"",
			66,
			1,
			""Mail"",
			""Email"",
			0
		],
		[
			""2019-04-18T12:00:00"",
			53,
			1,
			""secureacceptance.cybersource.com"",
			""Accounting"",
			2
		],
		[
			""2019-04-18T12:00:00"",
			47,
			1,
			""acs.nccc.com.tw"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-18T12:00:00"",
			43,
			1,
			""buyandship.com.tw"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T12:00:00"",
			29,
			1,
			""gap.tw"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T12:00:00"",
			22,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-18T12:00:00"",
			15,
			1,
			""instagram.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-18T12:00:00"",
			15,
			1,
			""keep.google.com"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-04-18T12:00:00"",
			9,
			1,
			""Blank Web Browser"",
			""Internet Utilities"",
			1
		],
		[
			""2019-04-18T12:00:00"",
			8,
			1,
			""csharp2json.io"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T12:00:00"",
			8,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T12:00:00"",
			5,
			1,
			""sourcetree"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T12:00:00"",
			3,
			1,
			""reddit.com"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-18T12:00:00"",
			3,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-18T13:00:00"",
			526,
			1,
			""reddit.com"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-18T13:00:00"",
			378,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-18T13:00:00"",
			319,
			1,
			""spotify"",
			""Music"",
			0
		],
		[
			""2019-04-18T13:00:00"",
			290,
			1,
			""term.ptt.cc"",
			""bbs"",
			-2
		],
		[
			""2019-04-18T13:00:00"",
			217,
			1,
			""Skype"",
			""Voice Chat"",
			1
		],
		[
			""2019-04-18T13:00:00"",
			137,
			1,
			""csharp2json.io"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T13:00:00"",
			110,
			1,
			""rescuetime.com"",
			""Intelligence"",
			2
		],
		[
			""2019-04-18T13:00:00"",
			82,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T13:00:00"",
			44,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-18T13:00:00"",
			41,
			1,
			""facebook.com"",
			""General Social Networking"",
			-2
		],
		[
			""2019-04-18T13:00:00"",
			40,
			1,
			""buyandship.com.tw"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T13:00:00"",
			34,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T13:00:00"",
			27,
			1,
			""rtls5wake"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T13:00:00"",
			21,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-18T13:00:00"",
			16,
			1,
			""ithelp.ithome.com.tw"",
			""Science \u0026 Technology"",
			-1
		],
		[
			""2019-04-18T13:00:00"",
			12,
			1,
			""timer"",
			""Intelligence"",
			2
		],
		[
			""2019-04-18T13:00:00"",
			12,
			1,
			""wrb.kcg.gov.tw"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T13:00:00"",
			11,
			1,
			""trackings.post.japanpost.jp"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-04-18T13:00:00"",
			9,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T13:00:00"",
			9,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-18T13:00:00"",
			8,
			1,
			""detail.i56.taobao.com"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-18T13:00:00"",
			8,
			1,
			""world.taobao.com"",
			""General Business"",
			2
		],
		[
			""2019-04-18T13:00:00"",
			7,
			1,
			""buyee.jp"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-18T13:00:00"",
			4,
			1,
			""buyertrade.taobao.com"",
			""General Shopping"",
			-2
		],
		[
			""2019-04-18T13:00:00"",
			4,
			1,
			""RescueTime"",
			""Intelligence"",
			2
		],
		[
			""2019-04-18T13:00:00"",
			3,
			1,
			""Blank Web Browser"",
			""Internet Utilities"",
			1
		],
		[
			""2019-04-18T13:00:00"",
			2,
			1,
			""searchui"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T13:00:00"",
			2,
			1,
			""adcontrol.sb.com"",
			""Quality Assurance"",
			2
		],
		[
			""2019-04-18T14:00:00"",
			2965,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-18T14:00:00"",
			292,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-18T14:00:00"",
			52,
			1,
			""docs.microsoft.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T14:00:00"",
			42,
			1,
			""Task Manager"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T14:00:00"",
			37,
			1,
			""blog.darkthread.net"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T14:00:00"",
			33,
			1,
			""stackoverflow.com"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T14:00:00"",
			33,
			1,
			""vstest.executionengine.x86"",
			""Quality Assurance"",
			2
		],
		[
			""2019-04-18T14:00:00"",
			29,
			1,
			""csharp2json.io"",
			""Uncategorized"",
			0
		],
		[
			""2019-04-18T14:00:00"",
			22,
			1,
			""Windows Explorer"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T14:00:00"",
			9,
			1,
			""Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-04-18T14:00:00"",
			8,
			1,
			""adcontrol.sb.com"",
			""Quality Assurance"",
			2
		],
		[
			""2019-04-18T14:00:00"",
			7,
			1,
			""Mail"",
			""Email"",
			0
		],
		[
			""2019-04-18T14:00:00"",
			6,
			1,
			""google.com"",
			""Search"",
			0
		],
		[
			""2019-04-18T14:00:00"",
			4,
			1,
			""sourcetree"",
			""General Software Development"",
			2
		],
		[
			""2019-04-18T14:00:00"",
			3,
			1,
			""Desktop Window Manager"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T14:00:00"",
			2,
			1,
			""shellexperiencehost"",
			""General Utilities"",
			1
		],
		[
			""2019-04-18T14:00:00"",
			1,
			1,
			""Skype"",
			""Voice Chat"",
			1
		],
		[
			""2019-04-18T14:00:00"",
			1,
			1,
			""line"",
			""Instant Message"",
			-1
		],
		[
			""2019-04-18T15:00:00"",
			595,
			1,
			""Visual Studio"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-04-18T15:00:00"",
			250,
			1,
			""linqpad"",
			""Data Modeling \u0026 Analysis"",
			2
		],
		[
			""2019-04-18T15:00:00"",
			139,
			1,
			""onenoteim"",
			""Writing"",
			2
		],
		[
			""2019-04-18T15:00:00"",
			1,
			1,
			""line"",
			""Instant Message"",
			-1
		]
	]";
	#endregion
	var jsonString = JsonConvert.DeserializeObject<List<List<string>>>(data);
	var ResObj = ConvertJsonArrayToApiActivityResponse(jsonString);
	ResObj.Dump();
}
private static List<ApiActivityResponse> ConvertJsonArrayToApiActivityResponse(List<List<string>> data)
{
	var destination = new List<ApiActivityResponse>(data.Count);
	foreach (var r in data)
	{
		destination.Add(new ApiActivityResponse
		{
			Date = DateTime.Parse(r[0]),
			TimeSpent = int.Parse(r[1]),
			NumberOfPeople = int.Parse(r[2]),
			Activity = r[3],
			Category = r[4],
			Productivity = (Productivity)int.Parse(r[5])

		});
	}
	return destination;
}
public class ApiActivityResponse
{
	public DateTime Date { get; set; }
	public int TimeSpent { get; set; }//花費時間 單位:秒
	public int NumberOfPeople { get; set; }
	public string Activity { get; set; }//程式名稱
	public string Category { get; set; }//程式分類
	public Productivity Productivity { get; set; }//生產力程度
}
public enum Productivity
{
	VeryDistracting = -2,
	Distraction = -1,
	Neutral = 0,
	Productive = 1,
	VeryProductive = 2
}
public class PeriodRule
{
	private int hour_begin = 0;
	private int hour_end = 0;
	public string PeriodName { get; set; }
	public int Hour_begin
	{
		get { return hour_begin; }
		set
		{
			hour_begin = (value < 0) ? 0 : (value > 24) ? 24 : value;
		}
	}
	public int Hour_end
	{
		get { return hour_end; }
		set
		{
			hour_end = (value < 0) ? 0 : (value > 24) ? 24 : value;
		}
	}
}