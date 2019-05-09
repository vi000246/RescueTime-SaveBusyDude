using Microsoft.VisualStudio.TestTools.UnitTesting;
using RescueTime_SaveBusyDude.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RescueTime_SaveBusyDude.Model;

namespace RescueTime_SaveBusyDude.BLL.Tests
{
    [TestClass()]
    public class AlertTests
    {
        #region fakeData
        public const string FakeData = @"
[
    [
			""2019-05-09T00:00:00"",
			707,
			1,
			""iamchucky.github.io"",
			""ptt.cc - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			500,
			1,
			""ikea.com"",
			""No Details"",
			""General Shopping"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			408,
			1,
			""rent.591.com.tw"",
			""No Details"",
			""General Entertainment"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			262,
			1,
			""facebook.com"",
			""Facebook Marketplace - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			223,
			1,
			""line"",
			""鐵心小帥 Silence Yimo"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T00:00:00"",
			113,
			1,
			""facebook.com"",
			""Facebook - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			108,
			1,
			""LINE"",
			""No Details"",
			""General Communication \u0026 Scheduling"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			103,
			1,
			""facebook.com"",
			""鐵心搬家 Iron Heart - 貼文 - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			80,
			1,
			""google.com"",
			""扶手椅 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			77,
			1,
			""ptt.cc"",
			""No Details"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			65,
			1,
			""24h.pchome.com.tw"",
			""No Details"",
			""General Shopping"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			57,
			1,
			""instagram.com"",
			""Instagram - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			53,
			1,
			""iamchucky.github.io"",
			""No Details"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			36,
			1,
			""NotePad++"",
			""*new 1 - Notepad++"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T00:00:00"",
			35,
			1,
			""google.com"",
			""辦公椅 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			33,
			1,
			""instagram.com"",
			""限時動態 • Instagram - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			33,
			1,
			""google.com"",
			""辦公椅無扶手 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			29,
			1,
			""google.com"",
			""沙發椅 單人 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			25,
			1,
			""imgur.com"",
			""Imgur: The magic of the Internet - Google Chrome"",
			""Photos"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			24,
			1,
			""google.com/calendar"",
			""Google 日曆 - 2019年5月 - Google Chrome"",
			""Calendars"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			22,
			1,
			""momoshop.com.tw"",
			""No Details"",
			""Video Editing"",
			2
		],
		[
			""2019-05-09T00:00:00"",
			21,
			1,
			""Windows Explorer"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T00:00:00"",
			20,
			1,
			""google.com"",
			""椅 無扶手 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			14,
			1,
			""ecshweb.pchome.com.tw"",
			""No Details"",
			""General Shopping"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			14,
			1,
			""newtab"",
			""New Tab - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			11,
			1,
			""shellexperiencehost"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T00:00:00"",
			10,
			1,
			""newtab"",
			""No Details"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			5,
			1,
			""591.com.tw"",
			""No Details"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-05-09T00:00:00"",
			5,
			1,
			""tw.mall.yahoo.com"",
			""No Details"",
			""General Shopping"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			4,
			1,
			""listary"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T00:00:00"",
			4,
			1,
			""google.com/calendar"",
			""Google 日曆 - 活動詳細資訊 - Google Chrome"",
			""Calendars"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			4,
			1,
			""iamchucky.github.io"",
			""PttChrome - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			4,
			1,
			""google.com"",
			""沙發椅 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			4,
			1,
			""instagram.com"",
			""No Details"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			3,
			1,
			""imgur.com"",
			""未命名 - Google Chrome"",
			""Photos"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			3,
			1,
			""find.ruten.com.tw"",
			""No Details"",
			""Sales"",
			2
		],
		[
			""2019-05-09T00:00:00"",
			3,
			1,
			""system idle process"",
			""No Details"",
			""Other"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			3,
			1,
			""Google Now"",
			""No Details"",
			""Search"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			3,
			1,
			""sharlok001.pixnet.net"",
			""No Details"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			2,
			1,
			""iamchucky.github.io"",
			""未命名 - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			2,
			1,
			""searchui"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T00:00:00"",
			2,
			1,
			""google.com/calendar"",
			""未命名 - Google Chrome"",
			""Calendars"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			2,
			1,
			""google.com"",
			""未命名 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			2,
			1,
			""NotePad++"",
			""*C:\\Users\\vi000\\Desktop\\Software_Developer\\2011NewAssessment\\programming-test\\c-sharp\\c-sharp-test.cs - Notepad++"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T00:00:00"",
			2,
			1,
			""iamchucky.github.io"",
			""工作桌 - IKEA - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T00:00:00"",
			2,
			1,
			""google.com"",
			""ikea 桌子 ptt site:www.ptt.cc - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			2,
			1,
			""NotePad++"",
			""Selected Tab"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T00:00:00"",
			2,
			1,
			""google.com"",
			""No Details"",
			""Search"",
			0
		],
		[
			""2019-05-09T00:00:00"",
			2,
			1,
			""NotePad++"",
			""C:\\MyProjects\\RescueTime-SaveBusyDude\\RescueTime-SaveBusyDude\\RescueTime-SaveBusyDude\\bin\\Debug\\AppConfig.json - Notepad++"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T00:00:00"",
			2,
			1,
			""Windows Explorer"",
			""進度"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T00:00:00"",
			1,
			1,
			""NotePad++"",
			""C:\\Program Files (x86)\\Notepad++\\change.log - Notepad++"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T00:00:00"",
			1,
			1,
			""line"",
			""展眉� May"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T00:00:00"",
			1,
			1,
			""Nova Launcher"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T00:00:00"",
			1,
			1,
			""line"",
			""LINE"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T00:00:00"",
			1,
			1,
			""NotePad++"",
			""new 1 - Notepad++"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T00:00:00"",
			1,
			1,
			""NotePad++"",
			""C:\\MyProjects\\RescueTime-SaveBusyDude\\RescueTime-SaveBusyDude\\RescueTime-SaveBusyDude\\RescueTime-SaveBusyDude.csproj - Notepad++"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T00:00:00"",
			1,
			1,
			""spotify"",
			""Nightwish - Over The Hills And Far Away"",
			""Music"",
			0
		],
		[
			""2019-05-09T01:00:00"",
			35,
			1,
			""spotify"",
			""F.I.R.飛兒樂團 - 雨櫻花"",
			""Music"",
			0
		],
		[
			""2019-05-09T01:00:00"",
			11,
			1,
			""spotify"",
			""Spotify Premium"",
			""Music"",
			0
		],
		[
			""2019-05-09T01:00:00"",
			3,
			1,
			""razer central"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T01:00:00"",
			1,
			1,
			""Windows Explorer"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T08:00:00"",
			630,
			1,
			""iamchucky.github.io"",
			""ptt.cc - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T08:00:00"",
			389,
			1,
			""facebook.com"",
			""Facebook - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T08:00:00"",
			96,
			1,
			""google.com/calendar"",
			""Google 日曆 - 活動詳細資訊 - Google Chrome"",
			""Calendars"",
			0
		],
		[
			""2019-05-09T08:00:00"",
			60,
			1,
			""line"",
			""Lucy"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T08:00:00"",
			54,
			1,
			""keep.google.com"",
			""No Details"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-05-09T08:00:00"",
			50,
			1,
			""facebook.com"",
			""Marketplace - 天狼星 藍牙摺疊鍵盤 BT-7269 - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T08:00:00"",
			28,
			1,
			""DeskClock for Android"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T08:00:00"",
			25,
			1,
			""news.ltn.com.tw"",
			""No Details"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-05-09T08:00:00"",
			23,
			1,
			""line"",
			""小陳(Rave) 平價搬家"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T08:00:00"",
			22,
			1,
			""newtab"",
			""No Details"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T08:00:00"",
			21,
			1,
			""google.com/calendar"",
			""Google 日曆 - 2019年7月 - Google Chrome"",
			""Calendars"",
			0
		],
		[
			""2019-05-09T08:00:00"",
			16,
			1,
			""google.com/calendar"",
			""Google 日曆 - 2019年5月 - Google Chrome"",
			""Calendars"",
			0
		],
		[
			""2019-05-09T08:00:00"",
			16,
			1,
			""line"",
			""LINE"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T08:00:00"",
			13,
			1,
			""shellexperiencehost"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T08:00:00"",
			10,
			1,
			""facebook.com"",
			""林逸宭 - 本人最近很窮 決定當二房東 有人想要短租台北內湖套房嗎 5/18前皆可住 - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T08:00:00"",
			8,
			1,
			""google.com/calendar"",
			""Google 日曆 - 2019年6月 - Google Chrome"",
			""Calendars"",
			0
		],
		[
			""2019-05-09T08:00:00"",
			6,
			1,
			""line"",
			""展眉� May"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T08:00:00"",
			5,
			1,
			""i.imgur.com"",
			""TsrqkQn.gif (980×613) - Google Chrome"",
			""General Entertainment"",
			-2
		],
		[
			""2019-05-09T08:00:00"",
			4,
			1,
			""Windows Explorer"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T08:00:00"",
			4,
			1,
			""spotify"",
			""蕭亞軒 - 最熟悉的陌生人"",
			""Music"",
			0
		],
		[
			""2019-05-09T08:00:00"",
			3,
			1,
			""facebook.com"",
			""No Details"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T08:00:00"",
			2,
			1,
			""spotify"",
			""Spotify Premium"",
			""Music"",
			0
		],
		[
			""2019-05-09T08:00:00"",
			2,
			1,
			""google.com/calendar"",
			""Google 日曆 - 2019年8月 - Google Chrome"",
			""Calendars"",
			0
		],
		[
			""2019-05-09T08:00:00"",
			2,
			1,
			""facebook.com"",
			""New Tab - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T08:00:00"",
			2,
			1,
			""google.com/calendar"",
			""Google 日曆 - 2019年9月 - Google Chrome"",
			""Calendars"",
			0
		],
		[
			""2019-05-09T08:00:00"",
			2,
			1,
			""google.com/calendar"",
			""未命名 - Google Chrome"",
			""Calendars"",
			0
		],
		[
			""2019-05-09T08:00:00"",
			2,
			1,
			""newtab"",
			""New Tab - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T08:00:00"",
			2,
			1,
			""google.com/calendar"",
			""Google 日曆 - Google Chrome"",
			""Calendars"",
			0
		],
		[
			""2019-05-09T08:00:00"",
			2,
			1,
			""facebook.com"",
			""未命名 - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T08:00:00"",
			2,
			1,
			""microsoft.photos"",
			""No Details"",
			""Photos"",
			-2
		],
		[
			""2019-05-09T08:00:00"",
			1,
			1,
			""line"",
			""帥哥隊"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T08:00:00"",
			1,
			1,
			""iamchucky.github.io"",
			""No Details"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T09:00:00"",
			348,
			1,
			""Messenger for Android"",
			""No Details"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T09:00:00"",
			65,
			1,
			""LINE"",
			""No Details"",
			""General Communication \u0026 Scheduling"",
			0
		],
		[
			""2019-05-09T09:00:00"",
			18,
			1,
			""Camera - Android"",
			""No Details"",
			""Photos"",
			-2
		],
		[
			""2019-05-09T09:00:00"",
			4,
			1,
			""Nova Launcher"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			882,
			1,
			""Visual Studio"",
			""AgileBet.Web.AdControl - Microsoft Visual Studio "",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T10:00:00"",
			366,
			1,
			""mobile - com.joshua.jptt"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			308,
			1,
			""Google Maps for Android"",
			""No Details"",
			""Maps \u0026 Regional"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			172,
			1,
			""microsoft.photos"",
			""No Details"",
			""Photos"",
			-2
		],
		[
			""2019-05-09T10:00:00"",
			163,
			1,
			""Google Chrome"",
			""Google Keep - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			110,
			1,
			""Skype"",
			""Skype"",
			""Voice Chat"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			105,
			1,
			""translate.google.com"",
			""Google 翻譯 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			100,
			1,
			""onenoteim"",
			""工作進度(軒昂) ‎- OneNote"",
			""Writing"",
			2
		],
		[
			""2019-05-09T10:00:00"",
			72,
			1,
			""sourcetree"",
			""Sourcetree"",
			""General Software Development"",
			2
		],
		[
			""2019-05-09T10:00:00"",
			48,
			1,
			""Instagram for Android"",
			""No Details"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T10:00:00"",
			40,
			1,
			""adcontrol.sb.com"",
			""No Details"",
			""Quality Assurance"",
			2
		],
		[
			""2019-05-09T10:00:00"",
			33,
			1,
			""keep.google.com"",
			""No Details"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			31,
			1,
			""Visual Studio"",
			""Start Page - Microsoft Visual Studio "",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T10:00:00"",
			31,
			1,
			""Visual Studio"",
			""JetPopupMenuView"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T10:00:00"",
			28,
			1,
			""Nova Launcher"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			22,
			1,
			""Skype"",
			""Skype [1]"",
			""Voice Chat"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			21,
			1,
			""dinbendon.net"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			18,
			1,
			""Google Chrome"",
			""New Tab - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			17,
			1,
			""Google Photos"",
			""No Details"",
			""Photos"",
			-2
		],
		[
			""2019-05-09T10:00:00"",
			13,
			1,
			""Windows Explorer"",
			""GoogleDriveNTU"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			13,
			1,
			""Windows Explorer"",
			""桌面"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			12,
			1,
			""google.com"",
			""室內設計 軟體 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			11,
			1,
			""ptt.cc"",
			""No Details"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T10:00:00"",
			10,
			1,
			""Facebook for Android"",
			""No Details"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T10:00:00"",
			10,
			1,
			""google.com"",
			""室內設計 軟體 ptt - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			10,
			1,
			""sweethome3d.com"",
			""No Details"",
			""General Design \u0026 Composition"",
			2
		],
		[
			""2019-05-09T10:00:00"",
			10,
			1,
			""Google Chrome"",
			""188BET - Home Page - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			9,
			1,
			""Google Chrome"",
			""No Details"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			8,
			1,
			""listary"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			8,
			1,
			""Android Dialer"",
			""No Details"",
			""Voice Chat"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			6,
			1,
			""system idle process"",
			""No Details"",
			""Other"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			6,
			1,
			""drive.google.com"",
			""未命名 - Google Chrome"",
			""General Business"",
			2
		],
		[
			""2019-05-09T10:00:00"",
			5,
			1,
			""Visual Studio"",
			""No Details"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T10:00:00"",
			4,
			1,
			""Google Chrome"",
			""188BET - Log in - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			4,
			1,
			""line"",
			""LINE"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T10:00:00"",
			3,
			1,
			""Google Chrome"",
			""未命名 - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			3,
			1,
			""phyllischan.blogspot.com"",
			""No Details"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-05-09T10:00:00"",
			2,
			1,
			""mobile - com.joaomgcd.join"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			2,
			1,
			""Google Chrome"",
			""adcontrol.sb.com/DSA/ResultProcessing/ResultProcessing.aspx - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T10:00:00"",
			2,
			1,
			""Windows Explorer"",
			""檔案總管"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			2,
			1,
			""Skype"",
			""No Details"",
			""Voice Chat"",
			1
		],
		[
			""2019-05-09T10:00:00"",
			1,
			1,
			""Android home screen"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T11:00:00"",
			1526,
			1,
			""Visual Studio"",
			""AgileBet.Web.AdControl - Microsoft Visual Studio "",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T11:00:00"",
			863,
			1,
			""Google Chrome"",
			""批踢踢實業坊"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T11:00:00"",
			472,
			1,
			""Skype"",
			""Skype"",
			""Voice Chat"",
			1
		],
		[
			""2019-05-09T11:00:00"",
			77,
			1,
			""keep.google.com"",
			""No Details"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-05-09T11:00:00"",
			75,
			1,
			""Skype"",
			""Skype [1]"",
			""Voice Chat"",
			1
		],
		[
			""2019-05-09T11:00:00"",
			72,
			1,
			""Google Chrome"",
			""188BET - Result Processing - Google Chrome"",
			""General Software Development"",
			2
		],
		[
			""2019-05-09T11:00:00"",
			54,
			1,
			""172.16.41.55"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			44,
			1,
			""adcontrol.sb.com"",
			""No Details"",
			""Quality Assurance"",
			2
		],
		[
			""2019-05-09T11:00:00"",
			38,
			1,
			""Google Chrome"",
			""New Tab - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			38,
			1,
			""google.com"",
			""電腦 接電視 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			35,
			1,
			""apowersoft.tw"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			28,
			1,
			""goods.ruten.com.tw"",
			""No Details"",
			""Sales"",
			2
		],
		[
			""2019-05-09T11:00:00"",
			26,
			1,
			""conemu64"",
			""No Details"",
			""General Software Development"",
			2
		],
		[
			""2019-05-09T11:00:00"",
			24,
			1,
			""google.com"",
			""chromecast 電腦 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			23,
			1,
			""Notepad"",
			""xuenn facebook.txt - 記事本"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T11:00:00"",
			21,
			1,
			""google.com"",
			""電視 旋轉底座 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			17,
			1,
			""google.com"",
			""ssh 登入ptt - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			13,
			1,
			""lmgtfy.com"",
			""No Details"",
			""General Business"",
			2
		],
		[
			""2019-05-09T11:00:00"",
			13,
			1,
			""onenoteim"",
			""工作進度(軒昂) ‎- OneNote"",
			""Writing"",
			2
		],
		[
			""2019-05-09T11:00:00"",
			11,
			1,
			""listary"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T11:00:00"",
			11,
			1,
			""google.com"",
			""電腦 輸出 電視 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			10,
			1,
			""Google Chrome"",
			""ahui3c.com 要求下列權限："",
			""Browsers"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			10,
			1,
			""google.com"",
			""joyce 7/26 生日 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			9,
			1,
			""Google Chrome"",
			""Facebook - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			9,
			1,
			""google.com"",
			""joyce0726 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			9,
			1,
			""ahui3c.com"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			8,
			1,
			""Google Chrome"",
			""Google Keep - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			8,
			1,
			""google.com"",
			""hdmi 舊電視 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			7,
			1,
			""google.com"",
			""d4db5efa3f761ee6 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			6,
			1,
			""google.com"",
			""小米掃地機器人 高度 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			5,
			1,
			""Google Chrome"",
			""未命名 - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			5,
			1,
			""dreamtails.pixnet.net"",
			""No Details"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-05-09T11:00:00"",
			4,
			1,
			""google.com"",
			""電腦 電視 無線 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			3,
			1,
			""d4db5efa3f761ee6"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			3,
			1,
			""google.com"",
			""Google Keep - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			3,
			1,
			""Google Chrome"",
			""電視機旋轉底座安裝|電視機旋轉底座高度|電視機旋轉底座價格|設計 - 淘寶海外 - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			3,
			1,
			""google.com"",
			""New Tab - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T11:00:00"",
			2,
			1,
			""shellexperiencehost"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T11:00:00"",
			2,
			1,
			""Windows Explorer"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T12:00:00"",
			761,
			1,
			""Visual Studio"",
			""AgileBet.Web.AdControl - Microsoft Visual Studio "",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T12:00:00"",
			546,
			1,
			""keep.google.com"",
			""No Details"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-05-09T12:00:00"",
			208,
			1,
			""24h.pchome.com.tw"",
			""No Details"",
			""General Shopping"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			202,
			1,
			""ikea.com"",
			""No Details"",
			""General Shopping"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			170,
			1,
			""Google Chrome"",
			""批踢踢實業坊"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			154,
			1,
			""item.taobao.com"",
			""No Details"",
			""General Shopping"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			118,
			1,
			""Skype"",
			""Skype"",
			""Voice Chat"",
			1
		],
		[
			""2019-05-09T12:00:00"",
			110,
			1,
			""mobile - com.andromoney.pro"",
			""No Details"",
			""General Communication \u0026 Scheduling"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			65,
			1,
			""world.taobao.com"",
			""No Details"",
			""General Business"",
			2
		],
		[
			""2019-05-09T12:00:00"",
			65,
			1,
			""Google Chrome"",
			""Netflix - Google Chrome"",
			""Video"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			62,
			1,
			""facebook.com"",
			""Facebook - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			60,
			1,
			""line"",
			""LINE"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T12:00:00"",
			59,
			1,
			""linemediaplayer"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			47,
			1,
			""Nova Launcher"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T12:00:00"",
			43,
			1,
			""goods.ruten.com.tw"",
			""No Details"",
			""Sales"",
			2
		],
		[
			""2019-05-09T12:00:00"",
			38,
			1,
			""Calculator"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T12:00:00"",
			35,
			1,
			""netflix.com"",
			""Netflix - Google Chrome"",
			""Video"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			34,
			1,
			""Google Chrome"",
			""批踢踢實業坊 - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			16,
			1,
			""Google Chrome"",
			""New Tab - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			16,
			1,
			""momoshop.com.tw"",
			""No Details"",
			""Video Editing"",
			2
		],
		[
			""2019-05-09T12:00:00"",
			15,
			1,
			""google.com"",
			""浴簾 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			14,
			1,
			""buy.taobao.com"",
			""No Details"",
			""General Shopping"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			13,
			1,
			""google.com"",
			""衣架 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			12,
			1,
			""cashiergtj.alipay.com"",
			""No Details"",
			""General Business"",
			2
		],
		[
			""2019-05-09T12:00:00"",
			11,
			1,
			""google.com"",
			""床腳 墊高 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			10,
			1,
			""Google Chrome"",
			""Google Keep - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			9,
			1,
			""Skype"",
			""Skype [1]"",
			""Voice Chat"",
			1
		],
		[
			""2019-05-09T12:00:00"",
			9,
			1,
			""google.com"",
			""ikea 轉角桌 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			9,
			1,
			""spotify"",
			""Spotify Premium"",
			""Music"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			9,
			1,
			""buyertrade.taobao.com"",
			""No Details"",
			""General Shopping"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			9,
			1,
			""Google Chrome"",
			""No Details"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			8,
			1,
			""trplus.com.tw"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			7,
			1,
			""adcontrol.sb.com"",
			""No Details"",
			""Quality Assurance"",
			2
		],
		[
			""2019-05-09T12:00:00"",
			6,
			1,
			""Google Chrome"",
			""編輯書籤"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			6,
			1,
			""market.fliggy.com"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			6,
			1,
			""imgur.com"",
			""New Tab - Google Chrome"",
			""Photos"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			4,
			1,
			""Google Chrome"",
			""Facebook - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			3,
			1,
			""Google Chrome"",
			""【GreeHook】不鏽鋼強力耐重伸縮桿 160-300cm/38kg - PChome 24h購物 - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			3,
			1,
			""term.ptt.cc"",
			""New Tab - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			3,
			1,
			""facebook.com"",
			""No Details"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			3,
			1,
			""google.com"",
			""曬衣架 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			3,
			1,
			""shellexperiencehost"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T12:00:00"",
			3,
			1,
			""google.com"",
			""New Tab - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			3,
			1,
			""netflix.com"",
			""188BET - Log in - Google Chrome"",
			""Video"",
			-2
		],
		[
			""2019-05-09T12:00:00"",
			2,
			1,
			""mobile - com.joshua.jptt"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			1,
			1,
			""spotify"",
			""張信哲 - 信仰"",
			""Music"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			1,
			1,
			""spotify"",
			""Feint - My Sunset - Original Mix"",
			""Music"",
			0
		],
		[
			""2019-05-09T12:00:00"",
			1,
			1,
			""system idle process"",
			""No Details"",
			""Other"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			493,
			1,
			""term.ptt.cc"",
			""批踢踢實業坊 - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			310,
			1,
			""Skype"",
			""Skype"",
			""Voice Chat"",
			1
		],
		[
			""2019-05-09T13:00:00"",
			197,
			1,
			""24h.pchome.com.tw"",
			""No Details"",
			""General Shopping"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			140,
			1,
			""trplus.com.tw"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			113,
			1,
			""youtube.com"",
			""(48) 韓導橋頭猛跳針 - YouTube - Google Chrome"",
			""Video"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			82,
			1,
			""line"",
			""LINE"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T13:00:00"",
			64,
			1,
			""Windows Explorer"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T13:00:00"",
			62,
			1,
			""facebook.com"",
			""蔣萬安 - 首頁 - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			59,
			1,
			""ikea.com"",
			""No Details"",
			""General Shopping"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			49,
			1,
			""momoshop.com.tw"",
			""No Details"",
			""Video Editing"",
			2
		],
		[
			""2019-05-09T13:00:00"",
			42,
			1,
			""accupass.com"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			38,
			1,
			""google.com"",
			""潭美國小 新明路 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			37,
			1,
			""Skype"",
			""Skype [1]"",
			""Voice Chat"",
			1
		],
		[
			""2019-05-09T13:00:00"",
			33,
			1,
			""news.ltn.com.tw"",
			""No Details"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			31,
			1,
			""Visual Studio"",
			""AgileBet.Web.AdControl - Microsoft Visual Studio "",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T13:00:00"",
			29,
			1,
			""Google Chrome"",
			""搜尋結果 - IKEA - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			23,
			1,
			""Google Chrome"",
			""New Tab - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			21,
			1,
			""Google Chrome"",
			""No Details"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			18,
			1,
			""term.ptt.cc"",
			""PChome 24h購物 - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			15,
			1,
			""google.com"",
			""潭美國小 遷校 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			14,
			1,
			""google.com"",
			""鏡子 黏 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			12,
			1,
			""keep.google.com"",
			""No Details"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-05-09T13:00:00"",
			12,
			1,
			""linemediaplayer"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			11,
			1,
			""term.ptt.cc"",
			""Facebook - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			10,
			1,
			""google.com"",
			""潭美國小 - Google 地圖 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			9,
			1,
			""google.com"",
			""衣帽架 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			9,
			1,
			""mall.pchome.com.tw"",
			""No Details"",
			""General News \u0026 Opinion"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			8,
			1,
			""treemall.com.tw"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			8,
			1,
			""term.ptt.cc"",
			""衣帽架,傘架/衣帽架/穿衣鏡,收納櫃/櫥櫃/屏風,傢俱寢飾-momo購物網 - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			8,
			1,
			""google.com"",
			""oa 辦公桌 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			7,
			1,
			""google.com"",
			""新明路93號 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			7,
			1,
			""google.com"",
			""潭美國小 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			7,
			1,
			""google.com"",
			""75 新明路 - Google 地圖 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			6,
			1,
			""Google Chrome"",
			""Google Keep - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			5,
			1,
			""google.com"",
			""114台北市內湖區新明路93號 - Google 地圖 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			5,
			1,
			""google.com"",
			""行善路 - Google 地圖 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			5,
			1,
			""Google Chrome"",
			""鞋架/衣帽架 - IKEA - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			4,
			1,
			""google.com"",
			""91 新明路 - Google 地圖 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			4,
			1,
			""spotify"",
			""Spotify Premium"",
			""Music"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			4,
			1,
			""timer"",
			""No Details"",
			""Intelligence"",
			2
		],
		[
			""2019-05-09T13:00:00"",
			4,
			1,
			""google.com"",
			""穿衣鏡 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			3,
			1,
			""google.com"",
			""New Tab - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			3,
			1,
			""facebook.com"",
			""No Details"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			3,
			1,
			""term.ptt.cc"",
			""TZUMii 藤木A字型衣架-原木色 - PChome 24h購物 - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			3,
			1,
			""google.com"",
			""ikea 衣帽架 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			3,
			1,
			""google.com"",
			""將萬安 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			3,
			1,
			""youtube.com"",
			""韓導橋頭猛跳針 - YouTube - Google Chrome"",
			""Video"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			3,
			1,
			""searchui"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T13:00:00"",
			3,
			1,
			""term.ptt.cc"",
			""鏡子 黏 - Google 搜尋 - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			3,
			1,
			""google.com"",
			""gmap - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			3,
			1,
			""google.com"",
			""Google 地圖 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			3,
			1,
			""facebook.com"",
			""蔣萬安 - Google 搜尋 - Google Chrome"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T13:00:00"",
			2,
			1,
			""spotify"",
			""張宇 - 用心良苦"",
			""Music"",
			0
		],
		[
			""2019-05-09T13:00:00"",
			1,
			1,
			""spotify"",
			""Charles Bolt - Hush Now"",
			""Music"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			1165,
			1,
			""adcontrol.sb.com"",
			""No Details"",
			""Quality Assurance"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			891,
			1,
			""Visual Studio"",
			""AgileBet.Web.AdControl - Microsoft Visual Studio "",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			231,
			1,
			""Google Chrome"",
			""批踢踢實業坊"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T14:00:00"",
			189,
			1,
			""onenoteim"",
			""工作進度(軒昂) ‎- OneNote"",
			""Writing"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			168,
			1,
			""sourcetree"",
			""Sourcetree"",
			""General Software Development"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			157,
			1,
			""Visual Studio"",
			""Gmm - Microsoft Visual Studio "",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			128,
			1,
			""keep.google.com"",
			""No Details"",
			""General Reference \u0026 Learning"",
			1
		],
		[
			""2019-05-09T14:00:00"",
			103,
			1,
			""google.com"",
			""政治大學東亞研究所 第十八屆 韓國瑜 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			86,
			1,
			""listary"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T14:00:00"",
			82,
			1,
			""LINE"",
			""No Details"",
			""General Communication \u0026 Scheduling"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			73,
			1,
			""Google Chrome"",
			""No Details"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			40,
			1,
			""autodeploy"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			35,
			1,
			""Visual Studio"",
			""JetPopupMenuView"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			31,
			1,
			""Google Chrome"",
			""188BET - Result Processing - Google Chrome"",
			""General Software Development"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			30,
			1,
			""runway.sb.com"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			26,
			1,
			""google.com"",
			""韓國瑜 學歷 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			24,
			1,
			""ly.gov.tw"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			24,
			1,
			""Nova Launcher"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T14:00:00"",
			22,
			1,
			""RescueTime"",
			""RescueTime"",
			""Intelligence"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			21,
			1,
			""Facebook for Android"",
			""No Details"",
			""General Social Networking"",
			-2
		],
		[
			""2019-05-09T14:00:00"",
			20,
			1,
			""Google Chrome"",
			""runway - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			20,
			1,
			""Windows Explorer"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T14:00:00"",
			16,
			1,
			""jira.ict888.net:8080"",
			""No Details"",
			""General Software Development"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			15,
			1,
			""Visual Studio"",
			""No Details"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			14,
			1,
			""mintty"",
			""MINGW64:/f/Projects/Backend/GMM/gmm-Web"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			13,
			1,
			""shellexperiencehost"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T14:00:00"",
			12,
			1,
			""Google Chrome"",
			""Google Keep - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			10,
			1,
			""mintty"",
			""/usr/bin/bash --login -i"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			8,
			1,
			""mintty"",
			""MINGW64:/f/Projects/Backend/GMM/gmm-domain"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T14:00:00"",
			5,
			1,
			""韓ohe"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			5,
			1,
			""Facebook Messenger"",
			""No Details"",
			""General Communication \u0026 Scheduling"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			5,
			1,
			""Google Chrome"",
			""188BET - Create Fixture Event - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			5,
			1,
			""Google Chrome"",
			""未命名 - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			5,
			1,
			""Google Chrome"",
			""New Tab - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			5,
			1,
			""Windows Explorer"",
			""AgileBet.Gmm.Entities"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T14:00:00"",
			4,
			1,
			""Windows Explorer"",
			""Debug"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T14:00:00"",
			3,
			1,
			""iamchucky.github.io"",
			""ptt.cc - Google Chrome"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T14:00:00"",
			3,
			1,
			""Windows Explorer"",
			""bin"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T14:00:00"",
			3,
			1,
			""google.com"",
			""148516,148510,148509 - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T14:00:00"",
			3,
			1,
			""line"",
			""LINE"",
			""Instant Message"",
			-1
		],
		[
			""2019-05-09T14:00:00"",
			2,
			1,
			""Desktop Window Manager"",
			""Gmm - Microsoft Visual Studio (沒有回應)"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T15:00:00"",
			250,
			1,
			""Visual Studio"",
			""RescueTime-SaveBusyDude - Microsoft Visual Studio "",
			""Side Project"",
			0
		],
		[
			""2019-05-09T15:00:00"",
			208,
			1,
			""jsonbuddyapp"",
			""No Details"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			169,
			1,
			""Visual Studio"",
			""AgileBet.Web.AdControl - Microsoft Visual Studio "",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			65,
			1,
			""Visual Studio"",
			""RescueTime-SaveBusyDude (Debugging) - Microsoft Visual Studio "",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			63,
			1,
			""google.com"",
			""jsonconvert.deserializeobject unexpected character escape - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T15:00:00"",
			42,
			1,
			""vstest.executionengine.x86"",
			""No Details"",
			""Quality Assurance"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			38,
			1,
			""Visual Studio"",
			""RescueTime-SaveBusyDude (Running) - Microsoft Visual Studio "",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			27,
			1,
			""linqpad"",
			""LINQPad 5"",
			""Data Modeling \u0026 Analysis"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			26,
			1,
			""jsonformatter.curiousconcept.com"",
			""No Details"",
			""General Software Development"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			25,
			1,
			""douduck08.com"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T15:00:00"",
			19,
			1,
			""stackoverflow.com"",
			""c# - Unexpected character encountered while parsing value - Stack Overflow - Google Chrome"",
			""General Software Development"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			15,
			1,
			""Visual Studio"",
			""No Details"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			15,
			1,
			""dotblogs.com.tw"",
			""No Details"",
			""General Software Development"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			14,
			1,
			""forums.asp.net"",
			""No Details"",
			""General Software Development"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			13,
			1,
			""adcontrol.sb.com"",
			""No Details"",
			""Quality Assurance"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			11,
			1,
			""google.com"",
			""jsonconvert.deserializeobject unexpected character encountered while parsing value . path - Google 搜尋 - Google Chrome"",
			""Search"",
			0
		],
		[
			""2019-05-09T15:00:00"",
			8,
			1,
			""Visual Studio"",
			""JetPopupMenuView"",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			7,
			1,
			""Visual Studio"",
			""Gmm - Microsoft Visual Studio "",
			""Editing \u0026 IDEs"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			7,
			1,
			""Google Chrome"",
			""批踢踢實業坊"",
			""bbs"",
			-2
		],
		[
			""2019-05-09T15:00:00"",
			7,
			1,
			""listary"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T15:00:00"",
			6,
			1,
			""Windows Explorer"",
			""No Details"",
			""General Utilities"",
			1
		],
		[
			""2019-05-09T15:00:00"",
			5,
			1,
			""sourcetree"",
			""Sourcetree"",
			""General Software Development"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			4,
			1,
			""rescuetime.com"",
			""188BET - Result Processing - Google Chrome"",
			""Intelligence"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			4,
			1,
			""Google Chrome"",
			""New Tab - Google Chrome"",
			""Browsers"",
			0
		],
		[
			""2019-05-09T15:00:00"",
			3,
			1,
			""linqpad"",
			""No Details"",
			""Data Modeling \u0026 Analysis"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			3,
			1,
			""rescuetime.com"",
			""RescueTime - Google Chrome"",
			""Intelligence"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			3,
			1,
			""stackoverflow.com"",
			""jsonconvert.deserializeobject unexpected character escape - Google 搜尋 - Google Chrome"",
			""General Software Development"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			3,
			1,
			""jsonconvert.deserializeobject"",
			""No Details"",
			""Uncategorized"",
			0
		],
		[
			""2019-05-09T15:00:00"",
			2,
			1,
			""onenoteim"",
			""工作進度(軒昂) ‎- OneNote"",
			""Writing"",
			2
		],
		[
			""2019-05-09T15:00:00"",
			1,
			1,
			""Visual Studio"",
			""Microsoft Visual Studio "",
			""Editing \u0026 IDEs"",
			2
		]
]
	";
        public List<List<string>> jsonString = ConfigUtil.Deserialize<List<List<string>>>(FakeData);
        #endregion


        [TestMethod()]
        public void CheckTimeSpendIsExceedByAlertTypeAndPeriodTest()
        {
            List<ApiActivityResponse> MockData = RescueTimeAPI.ConvertStringArrayToClass(jsonString);
            ConfigModel.AlertRule alertRule = new ConfigModel.AlertRule();
            alertRule.Hour = 1;
            alertRule.Minute = 0;
            alertRule.AlertType = EnumModule.AlertType.SpecificCategoryOrActivity;
            alertRule.SpecificName = new string[]
            { "ptt.cc", "ptt.cc - Google Chrome", "PttChrome - Google Chrome","批踢踢實業坊" };
            alertRule.PeriodName = new String[] { "全天" };
            alertRule.EnablePeriodName = new string[]{ "全天" };
            alertRule.EnableDays = new List<EnumModule.WeekDays>()
            {
                EnumModule.WeekDays.Monday,EnumModule.WeekDays.Tuesday,
                EnumModule.WeekDays.Wednesday,EnumModule.WeekDays.Thursday,EnumModule.WeekDays.Friday,
                EnumModule.WeekDays.Saturday,EnumModule.WeekDays.Sunday
            };
            bool result = new Alert().CheckTimeSpendIsExceedByAlertTypeAndPeriod(alertRule,MockData);
            Assert.IsInstanceOfType(result,typeof(Boolean));
        }
    }
}