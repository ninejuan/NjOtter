using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;

namespace NjOtter
{
    class Main
    {   
        public void encUNLOCK()
        {
            Console.WriteLine("Please Enter Your Password");
        }
        public void mkFolder()
        {
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = docpath + "/NjOtter Saves";
            string njh = "NjHidden";
            System.Diagnostics.Process.Start("md", path + njh);
            Console.WriteLine("Hidden Folder Created!");
            Commands();
        }
        public string id;
        public string password;
        public void fileDownload(String url, String path)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(url, path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }

        string versionName = "2022 LTS";
        string versionYear = "NjOtter C# 9.0";
        public void blank()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
        }
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enabling Librarys");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Starting NjOtter CLI");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000);
            Commands();
        }
        public void Commands()
        {
            for (; ; )
            { //for문을 사용한 이유 : for문이 if문에 있는 내용에 해당되지 않을 때 console이 강제 종료되는 것을 막기 위해서
                string username = string.Empty;
                username = Dns.GetHostName();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("nine@" + username);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" $ ");
                string command = Console.ReadLine();

                if (command == "")
                {
                    Commands();
                }
                if (command == "help")
                {
                    blank();
                    Console.WriteLine("vwip(v4) == Write Your IP v4 Address on Console");
                    Console.WriteLine("vwip(v6) == Write Your IP v6 Address on Console");
                    blank();
                    Console.WriteLine("whoami == Show This Computers' Name");
                    Console.WriteLine("sh int daynow == Show Time");
                    Console.WriteLine("change title == Change This Programs' Title");
                    Console.WriteLine("internet == Start Internet");
                    Console.WriteLine("server(web) == Starts Simple Web Server");
                    blank();
                    Console.WriteLine("sh str ip(conf) == View Internet Address [Windows Only]");
                    Console.WriteLine("sh str ip(ifcf) == View Internet Address [MacOS Only]");
                    Console.WriteLine("sh win str sysinf == Show My Computer's Information [Windows Only]");
                    Console.WriteLine("sh win str msinf == Show Computer's State [Windows Only]");
                    Console.WriteLine("sh win view netstat == Show My Computer's Network Status [Windows Only] [netstat]"); //nb옵션으로 바꾸기
                    Console.WriteLine("sh win ping4 == Show My Network's Ping [Windows Only]");
                    Console.WriteLine("sh win pathping == Show My Computer's Ping [Windows Only]");
                    Console.WriteLine("sh net dns to ip == Convert Domain to Ip Address");
                    Console.WriteLine("sh net route == Show Route Information");
                    Console.WriteLine("sh net arp == Show Arp Information");
                    blank();
                    Console.WriteLine("mode shw energy == Show My Computer's Energy Status [Windows Only]");
                    Console.WriteLine("shell win shw WinLicense == Show My Computer's Windows License Number [Windows Only]");
                    Console.WriteLine("mode shw reportbtr == Show My Computer's Battery Report [Windows Only]");
                    Console.WriteLine("net shw portforward == Check If Your Network is On PortForwarding");
                    Console.WriteLine("net ton portforward == Turn On PortForwarding On Port 9090");
                    Console.WriteLine("net toff portforward == Turn Off PortForwarding");
                    blank();
                    Console.WriteLine("machine bios == Show Bios Info");
                    Console.WriteLine("machine system == Show System Info");
                    Console.WriteLine("machine disk == Show Disk Info");
                    Console.WriteLine("machine cpu == Show Cpu Info");
                    Console.WriteLine("machine memory == Show Memory Info");
                    Console.WriteLine("machine bootconfig == Show Booting Config File");
                    Console.WriteLine("machine desktopinfo == Show Desktop Info");
                    Console.WriteLine("machine status memory == Show Memory Status");
                    Console.WriteLine("machine os enviornment == Show Os Environment Info");
                    Console.WriteLine("machine tasklist -sp == Show Specific tasklist");
                    Console.WriteLine("machine logon == Show Logon");
                    Console.WriteLine("machine netadaptor == Show Netadaptor Status");
                    Console.WriteLine("machine quick -f -eng == Wmic QFE");
                    Console.WriteLine("machine status share == Show share status");
                    Console.WriteLine("sudo -m shutdown /?");
                    blank();
                    Console.WriteLine("shell clear == Clear Shell");
                    Console.WriteLine("echo == Show Message");
                    Console.WriteLine("encrtpt folder == make private folder");
                    Console.WriteLine("random.number == Show Random Number");
                    Console.WriteLine("random.number.repeat10 == Show Random ten number");
                    blank();
                    Console.WriteLine("version == Show This Program's Version");
                    Console.WriteLine("gs || gscript == Starting GScript");
                    Console.WriteLine("gcn == Install Files");
                    Console.WriteLine("gc.net == Show This Program's Info"); //콘솔 라이트라인 넣기
                    Console.WriteLine("help, -h == List Available Commands");
                    Console.WriteLine("exit == Close This Program");
                    Console.WriteLine(""); //비워두기 : Command() 함수 이동 전 줄 띄기
                    Commands();
                }

                if (command == "-h")
                {
                    blank();
                    Console.WriteLine("vwip(v4) == Write Your IP v4 Address on Console");
                    Console.WriteLine("vwip(v6) == Write Your IP v6 Address on Console");
                    blank();
                    Console.WriteLine("whoami == Show This Computers' Name");
                    Console.WriteLine("sh int daynow == Show Time");
                    Console.WriteLine("change title == Change This Programs' Title");
                    Console.WriteLine("internet == Start Internet");
                    Console.WriteLine("server(web) == Starts Simple Web Server");
                    blank();
                    Console.WriteLine("sh str ip(conf) == View Internet Address [Windows Only]");
                    Console.WriteLine("sh str ip(ifcf) == View Internet Address [MacOS Only]");
                    Console.WriteLine("sh win str sysinf == Show My Computer's Information [Windows Only]");
                    Console.WriteLine("sh win str msinf == Show Computer's State [Windows Only]");
                    Console.WriteLine("sh win view netstat == Show My Computer's Network Status [Windows Only]"); //nb옵션으로 바꾸기
                    //Console.WriteLine("sh win netstat == ");
                    Console.WriteLine("sh win ping4 == Show My Network's Ping [Windows Only]");
                    Console.WriteLine("sh win pathping == Show My Computer's Ping [Windows Only]");
                    Console.WriteLine("sh net dns to ip == Convert Domain to Ip Address");
                    Console.WriteLine("sh net route == Show Route Information");
                    Console.WriteLine("sh net arp == Show Arp Information");
                    blank();
                    Console.WriteLine("gcn install filename == install files on web");
                    Console.WriteLine("mode shw energy == Show My Computer's Energy Status [Windows Only]");
                    Console.WriteLine("mode shw reportbtr == Show My Computer's Battery Report [Windows Only]");
                    Console.WriteLine("shell win shw WinLicense == Show My Computer's Windows License Number [Windows Only]");
                    Console.WriteLine("net shw portforward == Check If Your Network is On PortForwarding");
                    Console.WriteLine("net ton portforward == Turn On PortForwarding On Port 9090");
                    Console.WriteLine("net toff portforward == Turn Off PortForwarding");
                    blank();
                    Console.WriteLine("machine bios == Show Bios Info");
                    Console.WriteLine("machine system == Show System Info");
                    Console.WriteLine("machine disk == Show Disk Info");
                    Console.WriteLine("machine cpu == Show Cpu Info");
                    Console.WriteLine("machine memory == Show Memory Info");
                    Console.WriteLine("machine bootconfig == Show Booting Config File");
                    Console.WriteLine("machine desktopinfo == Show Desktop Info");
                    Console.WriteLine("machine status memory == Show Memory Status");
                    Console.WriteLine("machine os enviornment == Show Os Environment Info");
                    Console.WriteLine("machine tasklist -sp == Show Specific tasklist");
                    Console.WriteLine("machine logon == Show Logon");
                    Console.WriteLine("machine netadaptor == Show Netadaptor Status");
                    Console.WriteLine("machine quick -f -eng == Wmic QFE");
                    Console.WriteLine("machine status share == Show share status");
                    blank();
                    Console.WriteLine("shell clear == Clear Shell");
                    Console.WriteLine("echo == Show Message");
                    Console.WriteLine("encrtpt folder == make private folder");
                    Console.WriteLine("random.number == Show Random Number");
                    Console.WriteLine("random.number.repeat10 == Show Random ten number");
                    blank();
                    Console.WriteLine("version == Show This Program's Version");
                    Console.WriteLine("gs || gscript == Starting GScript");
                    Console.WriteLine("Gcn == Install Files");
                    Console.WriteLine("gc.net == Show This Program's Info"); //콘솔 라이트라인 넣기
                    Console.WriteLine("help, -h == List Available Commands");
                    Console.WriteLine("exit == Close This Program");
                    Console.WriteLine(""); //비워두기 : Command() 함수 이동 전 줄 띄기
                    Commands();
                }

                if (command == "hiddenmenu")
                {
                    blank();
                    Console.WriteLine("machine dir tree [Developing]"); //cmd tree
                    Console.WriteLine("shw extensions [Developing]"); //cmd assoc
                    Console.WriteLine("find exts + string [Developing]"); //cmd assoc + extensions
                    Console.WriteLine("tasklist"); // cmd tasklist
                    Console.WriteLine("win ver"); //cmd wmic os [windows version]
                    Console.WriteLine("GuCon.NET ,, WhoIsDeveloper"); //cmd ver
                    ///////////////////////////////////
                    Console.WriteLine("machine bios"); // wmic bios
                    Console.WriteLine("machine system"); //wmic computersystem
                    Console.WriteLine("machine disk"); //wmic diskdrive
                    Console.WriteLine("machine cpu"); //wmic cpu
                    Console.WriteLine("machine memory"); //wmic memorychip
                    Console.WriteLine("sh win net.client"); //wmic netclint
                    Console.WriteLine("sh win net.login"); //wmic netlogin
                    Console.WriteLine("sh win net.protocol"); //wmic netprotocol
                    Console.WriteLine("sh win net.use"); //wmic netuse
                    blank();
                    Console.WriteLine("sudo apt run control(server)");
                    Console.WriteLine("sudo apt run control help");
                    Console.WriteLine(""); //wmic 
                }

                if (command == "whoami")
                {
                    blank();
                    String cptname = string.Empty;
                    cptname = Dns.GetHostName();
                    Console.WriteLine("I am, " + cptname);
                    IPHostEntry ipEntry = Dns.GetHostEntry(cptname);
                    IPAddress[] addr = ipEntry.AddressList;
                    Console.WriteLine("");
                    Commands();
                }
                if (command == "vwip(v4)")
                {
                    blank();
                    string localIP = string.Empty;
                    using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                    {
                        socket.Connect("8.8.8.8", 65530);
                        IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                        localIP = endPoint.Address.ToString();
                    }
                    Console.WriteLine("Your IP V4 Address = " + localIP);
                    Console.WriteLine("");
                    Commands();
                }
                if (command == "vwip(v6)")
                {
                    blank();
                    string localIP = "Not available, please check your network seetings!";

                    IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

                    foreach (IPAddress ip in host.AddressList)
                    {
                        if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                        {
                            localIP = ip.ToString();
                            Console.WriteLine(localIP);
                            Console.WriteLine("");
                            Commands();
                        }
                    }
                    Console.WriteLine("");
                    Commands();
                }
                if (command == "exit") //버그수정
                {
                    blank();
                    Console.WriteLine("Exiting...");
                    return;
                }
                if (command == "internet") //버그 수정
                {
                    blank();
                    System.Diagnostics.Process.Start("start", "https://www.google.com");
                    Console.WriteLine("Opening Google...");
                    Console.WriteLine("");
                    Commands();
                }
                if (command == "server(web)")
                {
                    blank();
                    webserver ws = new webserver();
                    ws.subain();
                }
                if (command == "sh str ip(conf)") //버그수정
                {
                    blank();
                    System.Diagnostics.Process.Start("ipconfig");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(20000);
                    Console.WriteLine("");
                    Commands();

                }
                if (command == "sh str ip(ifcf)")
                {
                    blank();
                    System.Diagnostics.Process.Start("ifconfig");
                    System.Threading.Thread.Sleep(200);
                    Console.WriteLine("");
                    Commands();
                }
                if (command == "gc.net")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("This is Computer Manager Program");
                    Console.WriteLine("NjOtter requires Administrator");
                    Console.WriteLine("Because It Can Change Your Computer's setting.");
                    Console.WriteLine("And It Changes Your Network Setting, Show Computer's Status");
                    Console.WriteLine("");
                    Console.WriteLine("Programmed by NineJuan N913_");
                    Console.WriteLine("https://github.com/john0128/NjOtter");
                    Console.WriteLine("All Rights Reversed");
                    blank();
                    Commands();
                }
                if (command == "sh int daynow")
                {
                    blank();
                    DateTime dtn = DateTime.Now;
                    Console.WriteLine(dtn);
                    Console.WriteLine("");
                    Commands();
                }
                if (command == "sh win str sysinf") //버그수정
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Diagnostics.Process.Start("systeminfo");
                    System.Threading.Thread.Sleep(20000);
                    Console.WriteLine("");
                    Commands();
                }
                if (command == "sh win str msinf")
                {
                    blank();
                    System.Diagnostics.Process.Start("msinfo32");
                    blank();
                    Commands();
                }
                if (command == "sh win get model") //버그수정
                {
                    blank();
                    System.Diagnostics.Process.Start("wmic", "csproduct");
                    System.Threading.Thread.Sleep(5000);
                    blank();
                    Commands();
                }
                if (command == "sh win view netstat") //버그수정
                {
                    blank();
                    System.Diagnostics.Process.Start("netstat", "-n");
                    System.Threading.Thread.Sleep(12000);
                    blank();
                    Commands();
                }
                if (command == "sh win netstat")
                {
                    try
                    {
                        System.Diagnostics.Process.Start("netstat", "-nb");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
                if (command == "sh win ping4")
                {
                    blank();
                    Console.Write("Please Write Your IP Address: ");
                    string ipadd = Console.ReadLine();
                    blank();
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Diagnostics.Process.Start("ping", ipadd);
                    System.Threading.Thread.Sleep(7000);
                    blank();
                    Commands();
                }
                if (command == "control win reboot -c") //제거하기
                {
                    blank();
                    Console.WriteLine("5초 후 재부팅이 시작됩니다");
                    System.Diagnostics.Process.Start("cmd.exe", "shutdown -r -f -t 00");
                }
                if (command == "change title")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Please Enter What You Want: ");
                    string ttinp = Console.ReadLine();
                    Console.Title = ttinp;
                    blank();
                    Commands();
                }
                if (command == "sh win pathping")
                {
                    blank();
                    Console.Write("Please Write Your IP Address: ");
                    string ipadd = Console.ReadLine();
                    blank();
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Diagnostics.Process.Start("pathping", ipadd);
                    System.Threading.Thread.Sleep(60000);
                    blank();
                    Commands();
                }
                if (command == "mode shw energy")
                {
                    blank();
                    System.Diagnostics.Process.Start("powercfg", "/energy");
                    blank();
                    Commands();
                }
                if (command == "mode shw reportbtr")
                {
                    blank();
                    System.Diagnostics.Process.Start("powercfg", "/batteryreport");
                    System.Threading.Thread.Sleep(1000);
                    blank();
                    Commands();
                }
                if (command == "shell clear")
                {
                    blank();
                    Console.Clear();
                    Commands();
                }
                if (command == "net ton portforward")
                {
                    string ppon = "netsh interface portproxy add v4tov4 listenport=9090 listenaddress=192.168.0.4 connectport=9009 connectaddress=192.168.0.99";
                    blank();
                    System.Diagnostics.Process.Start("cmd.exe", ppon);
                    //System.Diagnostics.Process.Start("cmd.exe", "netsh interface portproxy add v4tov4 listenport=9090 listenaddress=192.168.0.4 connectport=9009 connectaddress=192.168.0.99");
                    blank();
                    Commands();
                }
                if (command == "net shw portforward")
                {
                    blank();
                    System.Diagnostics.Process.Start("cmd.exe", "netsh interface portproxy show v4tov4");
                    Commands();
                }
                if (command == "net toff portforward")
                {
                    blank();
                    string ppoff = "netsh interface portproxy delete v4tov4 listenport=9090 listenaddress=192.168.0.4";
                    System.Diagnostics.Process.Start(ppoff);
                    //System.Diagnostics.Process.Start("cmd.exe", "netsh interface portproxy delete v4tov4 listenport=9090 listenaddress=192.168.0.4");
                    Commands();
                }
                if (command == "shell win shw WinLicense")//버그수정
                {
                    /*string wmwinlinum;
                    wmwinlinum = "wmic + path + softwarelicensingservice + get + Oa3xOriginalProductKey";
                    blank();
                    System.Diagnostics.Process.Start("CMD.exe", wmwinlinum);*/
                    string me = "cmd.exe" + "wmic" + "path" + "softwarelicensingservice" + "get" + "Oa3xOriginalProductKey";
                    System.Diagnostics.Process.Start(me);
                    //System.Diagnostics.Process.Start("CMD.exe", "wmic path softwarelicensingservice get Oa3xOriginalProductKey");
                    System.Threading.Thread.Sleep(5000);
                    Commands();
                }
                if (command == "cmd")
                {
                    blank();
                    System.Diagnostics.Process.Start("cmd.exe");
                }
                if (command == "version")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("GuCon.NET Version");
                    Console.WriteLine("Version Year: " + versionYear);
                    Console.WriteLine("Version Name: " + versionName);
                    blank();
                    Commands();
                }
                if (command.StartsWith("echo "))
                {
                    string echotext = command.Substring(5);
                    Console.WriteLine(echotext);
                }
                if (command == "machine dir tree")
                {
                    blank();
                    System.Diagnostics.Process.Start("tree");
                    System.Threading.Thread.Sleep(15000);
                    Commands();
                }
                if (command == "sh win extensions")
                {
                    blank();
                    System.Diagnostics.Process.Start("cmd.exe", "assoc");
                    System.Threading.Thread.Sleep(10000);
                    Commands();
                }
                if (command == "find ext")
                {
                    blank();
                    Console.WriteLine("You Need to Write dot first");
                    Console.Write("Write What you want to find : ");
                    string extensionname = Console.ReadLine();
                    System.Diagnostics.Process.Start("assoc", extensionname);
                    Commands();
                }
                if (command == "tasklist")
                {
                    blank();
                    System.Diagnostics.Process.Start("tasklist");
                    System.Threading.Thread.Sleep(2000);
                    Commands();
                }
                if (command == "win ver -not.available")
                {
                    blank();
                    System.Diagnostics.Process.Start("ver");
                    Commands();
                }
                if (command == "win ver")
                {
                    blank();
                    System.Diagnostics.Process.Start("wmic", "os");
                    System.Threading.Thread.Sleep(2000);
                    Commands();
                }
                ////////////////////////211018
                if (command == "machine bios")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Diagnostics.Process.Start("wmic", "bios");
                    System.Threading.Thread.Sleep(1500);
                    Commands();
                }
                if (command == "machine system")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Diagnostics.Process.Start("wmic", "computersystem");
                    System.Threading.Thread.Sleep(1500);
                    Commands();
                }
                if (command == "machine disk")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Diagnostics.Process.Start("wmic", "diskdrive");
                    System.Threading.Thread.Sleep(1500);
                    Commands();
                }
                if (command == "machine cpu")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Diagnostics.Process.Start("wmic", "cpu");
                    System.Threading.Thread.Sleep(4000);
                    Commands();
                }
                if (command == "machine memory")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Diagnostics.Process.Start("wmic", "memorychip");
                    System.Threading.Thread.Sleep(1500);
                    Commands();
                }
                if (command == "sh win net.client")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Diagnostics.Process.Start("wmic", "netclient");
                    System.Threading.Thread.Sleep(700);
                    Commands();
                }
                if (command == "sh win net.login")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Diagnostics.Process.Start("wmic", "netlogin");
                    System.Threading.Thread.Sleep(700);
                    Commands();
                }
                if (command == "sh win net.use")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Diagnostics.Process.Start("wmic", "netuse");
                    System.Threading.Thread.Sleep(700);
                    Commands();
                }
                if (command == "sh win net.protocol")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Diagnostics.Process.Start("wmic", "netprotocol");
                    System.Threading.Thread.Sleep(700);
                    Commands();
                }
                if (command == "999999999")
                {
                    blank();
                    Color lime = Color.FromArgb(51, 255, 51);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" _____ ");
                    Console.WriteLine("|  _  |");
                    Console.WriteLine("| |_| |");
                    Console.WriteLine("|____ |");
                    Console.WriteLine(".___/ /");
                    Console.WriteLine("/____/ ");
                    Console.WriteLine("");
                }
                if (command == "NjOtter")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.Green;
                    string meme = @"

 _   _    _  _____  _    _               
| \ | |  (_)|  _  || |  | |              
|  \| |   _ | | | || |_ | |_   ___  _ __ 
| . ` |  | || | | || __|| __| / _ \| '__|
| |\  |  | |\ \_/ /| |_ | |_ |  __/| |   
\_| \_/  | | \___/  \__| \__| \___||_|   
        _/ |                             
       |__/                              

";
                    Console.WriteLine(meme);
                    Console.WriteLine("");
                }
                if (command == "sudoaptgetinstallasciiarttoliantoasciiartletteronthegrgr")
                {
                    blank();
                    Console.WriteLine("ads;");
                }
                if (command == "WhoIsDeveloper")
                {
                    blank();
                    string title = @"
______                     _                                 _   _  _                 ___                      
|  _  \                   | |                            _  | \ | |(_)               |_  |                     
| | | |  ___ __   __  ___ | |  ___   _ __    ___  _ __  (_) |  \| | _  _ __    ___     | | _   _   __ _  _ __  
| | | | / _ \\ \ / / / _ \| | / _ \ | '_ \  / _ \| '__|     | . ` || || '_ \  / _ \    | || | | | / _` || '_ \ 
| |/ / |  __/ \ V / |  __/| || (_) || |_) ||  __/| |     _  | |\  || || | | ||  __//\__/ /| |_| || (_| || | | |
|___/   \___|  \_/   \___||_| \___/ | .__/  \___||_|    (_) \_| \_/|_||_| |_| \___|\____/  \__,_| \__,_||_| |_|
                                    | |                                                                        
                                    |_|                                                                        
";
                    Console.WriteLine(title);
                    Console.WriteLine("https://github.com/john0128/NjOtter/");
                }
                if (command == "Info")
                {
                    blank();
                    string ninefo = @"";
                }
                if (command == "random.number")
                {
                    blank();
                    Console.Write("Please Write Max Value: ");
                    string rinput = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    var random = new Random();
                    int rinputToint = Int32.Parse(rinput);
                    int maxrdnum = rinputToint + 1;
                    int result = random.Next(1, maxrdnum);
                    Console.Write("Result: ");
                    Console.WriteLine(result);
                    blank();
                }
                if (command == "random.number.repeat10")
                {
                    blank();
                    Console.Write("Please Write Max Value: ");
                    string rinput = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    var random = new Random();
                    int rinputToint = Int32.Parse(rinput);
                    int maxrdnum = rinputToint + 1;
                    int result = random.Next(1, maxrdnum);
                    Console.Write("Result: ");
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    result = random.Next(1, maxrdnum);
                    Console.WriteLine(result);
                    blank();
                }
                if (command == "sh net dns to ip")
                {
                    blank();
                    Console.Write("Enter Domain What you want to check IP Address: ");
                    string dnsinput = Console.ReadLine();
                    System.Diagnostics.Process.Start("nslookup", dnsinput);
                    System.Threading.Thread.Sleep(300);
                }
                if (command == "sh net route")
                {
                    blank();
                    System.Diagnostics.Process.Start("route", "print");
                    System.Threading.Thread.Sleep(300);
                }
                if (command == "sh net arp")
                {
                    blank();
                    System.Diagnostics.Process.Start("arp", "-a");
                    System.Threading.Thread.Sleep(300);
                }
                if (command == "welcome")
                {
                    blank();
                    string anana = @"
 _    _  _____  _      _____  _____ ___  ___ _____ 
| |  | ||  ___|| |    /  __ \|  _  ||  \/  ||  ___|
| |  | || |__  | |    | /  \/| | | || .  . || |__  
| |/\| ||  __| | |    | |    | | | || |\/| ||  __| 
\  /\  /| |___ | |____| \__/\\ \_/ /| |  | || |___ 
 \/  \/ \____/ \_____/ \____/ \___/ \_|  |_/\____/ 
";
                    string bababa = @"

";
                }
                if (command == "the_end?")
                {
                    blank();
                    string developerletter = @"

______                     _                                
|  _  \                   | |                               
| | | |  ___ __   __  ___ | |  ___   _ __    ___  _ __  ___ 
| | | | / _ \\ \ / / / _ \| | / _ \ | '_ \  / _ \| '__|/ __|
| |/ / |  __/ \ V / |  __/| || (_) || |_) ||  __/| |   \__ \
|___/   \___|  \_/   \___||_| \___/ | .__/  \___||_|   |___/
                                    | |                     
                                    |_|                     
";
                    string devnamesshwend = @"
 _   _  _                 ___                        __ _____                                           ___  ___              __  
| \ | |(_)               |_  |                      / //  __ \                                          |  \/  |              \ \ 
|  \| | _  _ __    ___     | | _   _   __ _  _ __  | | | /  \/  ___   _ __ ___   _ __    __ _  ___  ___ | .  . |  __ _  _ __   | |
| . ` || || '_ \  / _ \    | || | | | / _` || '_ \ | | | |     / _ \ | '_ ` _ \ | '_ \  / _` |/ __|/ __|| |\/| | / _` || '_ \  | |
| |\  || || | | ||  __//\__/ /| |_| || (_| || | | || | | \__/\| (_) || | | | | || |_) || (_| |\__ \\__ \| |  | || (_| || | | | | |
\_| \_/|_||_| |_| \___|\____/  \__,_| \__,_||_| |_|| |  \____/ \___/ |_| |_| |_|| .__/  \__,_||___/|___/\_|  |_/ \__,_||_| |_| | |
                                                    \_\                         | |                                           /_/ 
                                                                                |_|                                               

";
                    string copyrighletter = @"

 _____                             _         _      _        
/  __ \                           (_)       | |    | |       
| /  \/  ___   _ __   _   _  _ __  _   __ _ | |__  | |_  ___ 
| |     / _ \ | '_ \ | | | || '__|| | / _` || '_ \ | __|/ __|
| \__/\| (_) || |_) || |_| || |   | || (_| || | | || |_ \__ \
 \____/ \___/ | .__/  \__, ||_|   |_| \__, ||_| |_| \__||___/
              | |      __/ |           __/ |                 
              |_|     |___/           |___/                  

";
                    string copyrightsend = @"
  __ _____ __    _   _  _                 ___                      
 / //  __ \\ \  | \ | |(_)               |_  |                     
| | | /  \/ | | |  \| | _  _ __    ___     | | _   _   __ _  _ __  
| | | |     | | | . ` || || '_ \  / _ \    | || | | | / _` || '_ \ 
| | | \__/\ | | | |\  || || | | ||  __//\__/ /| |_| || (_| || | | |
| |  \____/ | | \_| \_/|_||_| |_| \___|\____/  \__,_| \__,_||_| |_|
 \_\       /_/                                                     
                                                                   

";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(developerletter);
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(devnamesshwend);
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(copyrighletter);
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(copyrightsend);
                }
                if (command == "copyrights")
                {
                    blank();
                    Console.WriteLine("(c)GuNine, https://github.com/john0128/NjOtter/");
                    Console.WriteLine("All Rights Reversed");
                    blank();
                }
                if (command == "gcn install /?")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Available files List");
                    blank();
                    Console.WriteLine("python 3.10.0 (-gcn install python");
                    Console.WriteLine("node.js 16.13.0 (-gcn install nodejs");
                    Console.WriteLine("vscode (-gcn install vscode");
                    Console.WriteLine("vs2019 (-gcn install vs2019");
                    Console.WriteLine("github (-gcn install github");
                    Console.WriteLine("windows terminal (-gcn install wintm");
                    Console.WriteLine("android studio (-gcn install android-studio");
                    Console.WriteLine("ruby (-gcn install ruby");
                    Console.WriteLine("nuget (-gcn install nuget");
                    Console.WriteLine(".NET 5.0 SDK (-gcn install .net5sdk");
                    Console.WriteLine(".NET 5.0 Runtime (-gcn install .net5run");
                    Console.WriteLine("chrome (-gcn install chrome");
                    Console.WriteLine("zoom (-gcn install zoom");
                    Console.WriteLine("java8 (-gcn install java");
                    Console.WriteLine("enable wsl (-gcn install -e wsl");
                    Console.WriteLine("install wsl (-gcn install wsl");
                    Console.WriteLine("enable ISS (-gcn install -e iss");
                    Console.WriteLine("gcn installpath == show path of install files");
                }
                if (command == "gcn install python")
                {
                    blank();
                    fileDownload("https://www.python.org/ftp/python/3.10.0/python-3.10.0-amd64.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\python.exe");
                }
                if (command == "gcn install nodejs")
                {
                    blank();
                    fileDownload("https://nodejs.org/dist/v16.13.0/node-v16.13.0-x64.msi", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\nodejs.msi");
                }
                if (command == "gcn install vscode")
                {
                    blank();
                    fileDownload("https://az764295.vo.msecnd.net/stable/6cba118ac49a1b88332f312a8f67186f7f3c1643/VSCodeUserSetup-x64-1.61.2.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\vscode.exe");
                }
                /*if (command == "gcn install vs2019")
                {
                    blank();
                    fileDownload("blob:https://visualstudio.microsoft.com/3cde0870-8a65-446d-a329-010554f45e50", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\me.exe");
                }*/
                if (command == "gcn install github")
                {
                    blank();
                    fileDownload("https://desktop.githubusercontent.com/github-desktop/releases/2.9.4-24101633/GitHubDesktopSetup-x64.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\github.exe");
                }
                /*if (command == "gcn install wintm")
                {
                    blank();
                    fileDownload("https://github-releases.githubusercontent.com/78153411/8573a700-e104-11eb-972d-2c6a9345ed61?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAIWNJYAX4CSVEH53A%2F20211030%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20211030T044714Z&X-Amz-Expires=300&X-Amz-Signature=000b9165c742cc9b19c815da93e93d1d9fea0dd8a76d22c82b4445f4a52fefe0&X-Amz-SignedHeaders=host&actor_id=79080468&key_id=0&repo_id=78153411&response-content-disposition=attachment%3B%20filename%3Drubyinstaller-devkit-2.7.4-1-x64.exe&response-content-type=application%2Foctet-stream", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\");
                }*/
                if (command == "gcn install android-studio")
                {
                    blank();
                    fileDownload("https://r5---sn-n3cgv5qc5oq-bh2ss.gvt1.com/edgedl/android/studio/install/2020.3.1.25/android-studio-2020.3.1.25-windows.exe?cms_redirect=yes&mh=II&mip=127.0.0.1&mm=28&mn=sn-n3cgv5qc5oq-bh2ss&ms=nvh&mt=1635567731&mv=u&mvi=5&pl=26&rmhost=r2---sn-n3cgv5qc5oq-bh2ss.gvt1.com&shardbypass=yes&smhost=r2---sn-n3cgv5qc5oq-bh2sd.gvt1.com", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\android-studio.exe");
                }
                if (command == "gcn install ruby")
                {
                    blank();
                    fileDownload("https://github-releases.githubusercontent.com/78153411/8573a700-e104-11eb-972d-2c6a9345ed61?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAIWNJYAX4CSVEH53A%2F20211030%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20211030T044714Z&X-Amz-Expires=300&X-Amz-Signature=000b9165c742cc9b19c815da93e93d1d9fea0dd8a76d22c82b4445f4a52fefe0&X-Amz-SignedHeaders=host&actor_id=79080468&key_id=0&repo_id=78153411&response-content-disposition=attachment%3B%20filename%3Drubyinstaller-devkit-2.7.4-1-x64.exe&response-content-type=application%2Foctet-stream", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ruby.exe");
                }
                if (command == "gcn install nuget")
                {
                    blank();
                    fileDownload("https://dist.nuget.org/win-x86-commandline/v5.11.0/nuget.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\nuget.exe");
                }
                if (command == "gcn install .net5sdk")
                {
                    blank();
                    fileDownload("https://download.visualstudio.microsoft.com/download/pr/8a504918-9508-464d-80c6-4da7f9cc9ac6/f9d6ad00bbd798bafb549101b5b4a4c0/dotnet-sdk-5.0.402-win-x64.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NET5.0_SDK.exe");
                }
                if (command == "gcn install .net5run")
                {
                    blank();
                    fileDownload("https://download.visualstudio.microsoft.com/download/pr/240681b9-686b-4147-bda0-ae3004addc6d/dba078f8eb8e6f9a6a9f616c414ef365/dotnet-runtime-5.0.11-win-x64.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NET5.0_Runtime.exe");
                }
                if (command == "gcn install zoom")
                {
                    blank();
                    fileDownload("https://cdn.zoom.us/prod/5.8.3.1581/x64/ZoomInstaller.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\zoom.exe");
                }
                if (command == "gcn install chrome")
                {
                    blank();
                    fileDownload("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BB6A97DB0-282E-889E-F54A-150ADBA28085%7D%26lang%3Dko%26browser%3D4%26usagestats%3D1%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\chrome.exe");
                }
                if (command == "gcn installpath")
                {
                    blank();
                    Console.WriteLine("C:\\Users\\user\\Documents");
                }
                if (command == "machine bootconfig")
                {
                    blank();
                    System.Diagnostics.Process.Start("wmic", "bootconfig");
                    System.Threading.Thread.Sleep(400);
                }
                if (command == "machine desktopinfo")
                {
                    blank();
                    System.Diagnostics.Process.Start("wmic", "desktop");
                    System.Threading.Thread.Sleep(200);
                }
                if (command == "machine status memory")
                {
                    blank();
                    System.Diagnostics.Process.Start("wmic", "DEVICEMEMORYADDRESS");
                    System.Threading.Thread.Sleep(700);
                }
                if (command == "machine os enviornment")
                {
                    blank();
                    System.Diagnostics.Process.Start("wmic", "ENVIRONMENT");
                    System.Threading.Thread.Sleep(200);
                }
                if (command == "machine tasklist -sp")
                {
                    blank();
                    System.Diagnostics.Process.Start("tasklist", "-v");
                    System.Threading.Thread.Sleep(10000);
                }
                if (command == "machine logon")
                {
                    blank();
                    System.Diagnostics.Process.Start("wmic", "LOGON");
                    System.Threading.Thread.Sleep(400);
                }
                if (command == "machine netadaptor")
                {
                    blank();
                    System.Diagnostics.Process.Start("wmic", "NICCONFIG");
                    System.Threading.Thread.Sleep(400);
                }
                if (command == "machine quick -f -eng")
                {
                    blank();
                    System.Diagnostics.Process.Start("wmic", "QFE");
                    System.Threading.Thread.Sleep(600);
                }
                if (command == "machine status share")
                {
                    blank();
                    System.Diagnostics.Process.Start("wmic", "SHARE");
                    System.Threading.Thread.Sleep(400);
                }
                if (command == "gchat_server")
                {
                    blank();
                    var gcserver = new GChat_sever();
                    gcserver.chatmain();
                }
                if (command == "gchat_client")
                {
                    blank();
                    var gcclient = new gcmain();
                    gcclient.gclient_main();
                }
                if (command == "gcn install -c")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    blank();
                    Console.Write("Please Write FileLink: ");
                    string fileurl = Console.ReadLine();
                    Console.Write("Please Write Filename: ");
                    string filename = Console.ReadLine();
                    try
                    {
                        fileDownload(fileurl, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + filename);
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(e.ToString());
                        Commands();
                    }
                }
                if (command == "mkdir ")
                {
                    blank();
                    string newdirname = command.Substring(6);
                    Console.WriteLine(newdirname);
                    //System.Diagnostics.Process.Start("mkdir", newdirname);
                    //Console.WriteLine("das");
                }
                if (command == "sudo apt run unicode_bug")
                {
                    string blankicofirst = @"
@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@
";
                    string blankicolast = @"
@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@
";
                    string icon = @"
@@@@:@@@@@@@@@@@@@@@@@@@@@@
@@@@  *##@@@@@@@@@@@@@@@@@@
@@@@    -*@@@@@@@@@@@@@@@@@
@@@@*~  ..~;@@@@@@@@@@@@@@@
@@@@@##$....!@@@@@@@@@@@@@@
@@@@@$==....*@@@@@@@@@@@@@@
@@@@;-....;*@@@@@@@@@@@@@@@
@@@@....~$@@@@@@@@@@@@@@@@@
@@@@..$@@@@@@@@@@@@@@@@@@@@
@@@@;@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@=::::::::@@@@@@
@@@@@@@@@@@@;........@@@@@@
@@@@@@@@@@@@*--------@@@@@@";
                    ConsoleKeyInfo ckinfo;
                    Console.WriteLine("Press Enter!");
                    do
                    {
                        ckinfo = Console.ReadKey();
                        if (ckinfo.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("Press Enter Again!");
                        }
                    } while (ckinfo.Key != ConsoleKey.Enter);
                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "sudo -m shutdown -s")
                {
                    blank();
                    //즉시종료
                    System.Diagnostics.Process.Start("shutdown", "-s");
                }
                if (command == "sudo -m shutdown -cancel")
                {
                    blank();
                    //셧다운취소
                    System.Diagnostics.Process.Start("shutdown", "-a");
                }
                if (command == "sudo -m shutdown -reboot")
                {
                    blank();
                    //셧다운리부트
                    System.Diagnostics.Process.Start("shutdown", "-r");
                }
                if (command == "sudo -m shutdown /?")
                {
                    blank();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("sudo shutdown Helper");
                    Console.WriteLine("");
                    Console.WriteLine("-cancel == Cansel Shutdown Event");
                    Console.WriteLine("-reboot == Reboot System");
                    Console.WriteLine("-s == Shutdown System 1 Minute");
                    blank();
                }
                if (command == "new console")
                {
                    blank();
                    Console.Clear();
                }
                if (command == "gcn install -e wsl")
                {
                    blank();
                    string wslcommand = "/online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart";
                    try
                    {
                        System.Diagnostics.Process.Start("dism", "/online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart");
                        System.Diagnostics.Process.Start("dism", "/online /enable-feature /featurename:VirtualMachinePlatform /all /norestart");
                        System.Threading.Thread.Sleep(10000);
                        Console.WriteLine("You need to reboot computer");
                        Console.WriteLine("You can reboot with this command : sudo -m shutdown -reboot");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("You Need to Start This Program Administration mode");
                    }
                }
                if (command == "gcn install wsl")
                {
                    blank();
                    System.Diagnostics.Process.Start("start", "https://aka.ms/wslstore");
                }
                if (command == "gcn install -e iss")
                {
                    blank();
                    try
                    {
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:NetFx3 /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:WCF-HTTP-Activation /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:WCF-NonHTTP-Activation /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:NetFx4-AdvSrvs /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:WCF-TCP-PortSharing45 /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:NetFx4Extended-ASPNET45 /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-WindowsAuthentication /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-BasicAuthentication /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-RequestFiltering /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-HttpLogging /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-ODBCLogging /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-HttpErrors /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-DefaultDocument /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-DirectoryBrowsing /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-StaticContent /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-IIS6ManagementCompatibility /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-Metabase /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-ManagementService /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-ManagementScriptingTools /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-ManagementConsole /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-ApplicationDevelopment /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-NetFxExtensibility /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-NetFxExtensibility45 /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-ASPNET /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-ASPNET45 /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-ISAPIExtensions /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-ISAPIFilter /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-ServerSideIncludes /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-WebSockets /all");
                        System.Diagnostics.Process.Start("dism", "/online /Enable-Feature /FeatureName:IIS-ApplicationInit /all");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("You Need to Start This Program in Administration mode");
                    }
                }
                if (command == "sudo apt run control(server)")
                {
                    blank();
                    System.Diagnostics.Process.Start("start", "compmgmt.msc");
                }
                if (command == "sudo apt run control help")
                {
                    blank();
                    System.Diagnostics.Process.Start("start", "https://yoons-family.tistory.com/296");
                }
                if (command == "gcn install java")
                {
                    blank();
                    fileDownload("https://sdlc-esd.oracle.com/ESD6/JSCDL/jdk/8u311-b11/4d5417147a92418ea8b615e228bb6935/jre-8u311-windows-x64.exe?GroupName=JSC&FilePath=/ESD6/JSCDL/jdk/8u311-b11/4d5417147a92418ea8b615e228bb6935/jre-8u311-windows-x64.exe&BHost=javadl.sun.com&File=jre-8u311-windows-x64.exe&AuthParam=1635944646_3dc221fa33d5cbe47a1d4c4b65d3475e&ext=.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\java8.exe");
                }
                if (command == "exit")
                {
                    blank();
                    Environment.Exit(0);
                }
                if (command == "close")
                {
                    blank();
                    Environment.Exit(0);
                }
                if (command == "Exit")
                {
                    blank();
                    Environment.Exit(0);
                }
                if (command == "gscript")
                {
                    blank();
                    var gs = new gscript();
                    gs.GscriptMain();
                }
                if (command == "GuNine")
                {
                    blank();

                }
                if (command == "encrypt folder")
                {
                    blank();
                    Console.WriteLine("Starting NjOtter Encryption tools");
                    string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string path = docpath + "//NjOtter Saves//Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}";
                    DirectoryInfo drinfo = new DirectoryInfo(path);
                    if (drinfo.Exists == true)
                    {
                        encUNLOCK();
                    }
                    if (drinfo.Exists == false)
                    {
                        mkFolder();
                    }
                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();
                    
                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
                if (command == "")
                {
                    blank();

                }
            }
        }
    }
    class gscript
    {
        public void GscriptMain()
        {
            Console.WriteLine("Starting Gsc");
            System.Threading.Thread.Sleep(654);
            Console.WriteLine("Get gs Files From Server");
            System.Threading.Thread.Sleep(654);
            Console.WriteLine("Loading Dlls.");
            System.Threading.Thread.Sleep(654);
            gscst();
        }
        private void gscst()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("gsc@root>");
            var gsinput = Console.ReadLine();
            if (gsinput == "-h")
            {
                Console.WriteLine("write");
                Console.WriteLine("read");
                Console.WriteLine("remove");
                Console.WriteLine("create");
                Console.WriteLine("checkgst");
                Console.WriteLine("edit");
                Console.WriteLine("");
                Console.WriteLine("gsver");
                Console.WriteLine("info");
            }
            if (gsinput == "write")
            {
                string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string savepath = docpath + "/GuCon.NET Saves";
                Console.Write("Please Write Filename: ");
                string inputfilename = Console.ReadLine();
                Console.Write("Please Write Your Memo: ");
                string inputgst = Console.ReadLine();
                StreamWriter writer;
                string filnm = inputfilename + ".gst";
                writer = File.CreateText(filnm);
                //System.IO.File.WriteAllText(savepath, inputgst, System.Text.Encoding.Default);
            }
            if (gsinput == "read")
            {

            }
            if (gsinput == "remove")
            {

            }
            if (gsinput == "create")
            {

            }
            if (gsinput == "checkgst")
            {

            }
            if (gsinput == "edit")
            {

            }
            if (gsinput == "")
            {

            }
            if (gsinput == "gsver")
            {

            }
            if (gsinput == "info")
            {

            }
        }
    }
    class serverH
    {
        StreamReader reader = null;
        public serverH(StreamReader reader)
        {
            this.reader = reader;
        }
        //서버에서 불특정하게 날아오는 다른 Client가 쓴 내용을
        //받기 위해 클라이언트의 글읽는 부분을 쓰레드로 처리
        public void chat()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    class gcmain
    {
        public void gclient_main()
        {
            TcpClient client = null;
            try
            {
                //LocalHost에 지정 포트로 TCP Connection을 생성하고 데이터를 송수신 하기
                //위한 스트림을 얻는다. 
                client = new TcpClient();
                client.Connect("localhost", 5001);
                NetworkStream stream = client.GetStream();
                Encoding encode = System.Text.Encoding.GetEncoding("euc-kr");
                StreamReader reader = new StreamReader(stream, encode);
                StreamWriter writer = new StreamWriter(stream, encode)
                { AutoFlush = true };
                //글읽는 부분을 ServerHandler에서 처리하도록 쓰레드로 만든다.
                serverH serverHandler = new serverH(reader);
                Thread t = new Thread(new ThreadStart(serverHandler.chat));
                t.Start();

                string dataToSend = Console.ReadLine();

                while (true)
                {
                    writer.WriteLine(dataToSend);
                    if (dataToSend.IndexOf("<EOF>") > -1) break;
                    dataToSend = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                client.Close();
                client = null;
            }
        }
    }
    class GChat_sever
    {
        static List<Socket> clientSockets = new List<Socket>();
        public void chatmain()
        {
            Console.WriteLine("");
            //IP주소를 나타내는 객체,TcpListener를 생성시 인자로 사용

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            try
            {
                //TcpListener Class를 이용하여 클라이언트의 연결을 받아 들인다.
                TcpListener listener = new TcpListener(ip, 5001);
                listener.Start();
                //서버프로그램은 데몬프로그램처럼 늘 기동되어 있어야 하므로 무한루프로
                while (true)
                {
                    Socket socket = listener.AcceptSocket();
                    new Thread(() => chat(socket)).Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        //Thread가 실행할 메소드, 인자로 클라이언트 전담 소켓을 받는다.
        static void chat(Socket socket)
        {
            Encoding encoding = Encoding.GetEncoding("euc-kr");
            try
            {
                clientSockets.Add(socket);
                StreamReader reader = new StreamReader(new NetworkStream(socket), encoding);
                string line;
                while ((line = readLine(reader)) != null)
                {
                    Console.WriteLine(line);
                    // ArrayList에 보관된 모든 클라이언트 처리 소켓만큼
                    // 현재 접속한 모든 클라이언트에게 글을 씀
                    foreach (Socket clientSocket in clientSockets)
                    {
                        //클라이언트의 데이터를 읽고, 쓰기 위한 스트림을 만든다. 
                        NetworkStream stream = new NetworkStream(clientSocket);
                        StreamWriter writer = new StreamWriter(stream, encoding) { AutoFlush = true };
                        writer.WriteLine(line);
                        writer.Close();
                    }
                }
            }
            catch
            {

            }
            finally
            {
                clientSockets.Remove(socket);
                socket.Close();
                socket = null;
            }
        }
        static string readLine(StreamReader reader)
        {
            try
            {
                return reader.ReadLine();
            }
            catch
            {
                return null;
            }

        }
    }
    class webserver
    {
        public static HttpListener listener;
        public static string url = "http://localhost:9999/";
        public static int pageViews = 0;
        public static int requestCount = 0;
        public static string pageData =
            "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>HttpListener Example</title>" +
            "  </head>" +
            "  <body>" +
            "    <p>Page Views: {0}</p>" +
            "    <form method=\"post\" action=\"shutdown\">" +
            "      <input type=\"submit\" value=\"Shutdown\" {1}>" +
            "    </form>" +
            "  </body>" +
            "</html>";


        public static async Task HandleIncomingConnections()
        {
            bool runServer = true;

            // While a user hasn't visited the `shutdown` url, keep on handling requests
            while (runServer)
            {
                // Will wait here until we hear from a connection
                HttpListenerContext ctx = await listener.GetContextAsync();

                // Peel out the requests and response objects
                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse resp = ctx.Response;

                Console.ForegroundColor = ConsoleColor.Yellow;
                // Print out some info about the request
                Console.WriteLine("Request #: {0}", ++requestCount);
                Console.WriteLine(req.Url.ToString());
                Console.WriteLine(req.HttpMethod);
                Console.WriteLine(req.UserHostName);
                Console.WriteLine(req.UserAgent);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;

                // If `shutdown` url requested w/ POST, then shutdown the server after serving the page
                if ((req.HttpMethod == "POST") && (req.Url.AbsolutePath == "/shutdown"))
                {
                    Console.WriteLine("Shutdown requested");
                    runServer = false;
                    Console.WriteLine("");
                    Main main = new Main();
                    main.Commands();
                }

                // Make sure we don't increment the page views counter if `favicon.ico` is requested
                if (req.Url.AbsolutePath != "/favicon.ico")
                    pageViews += 1;

                // Write the response info
                string disableSubmit = !runServer ? "disabled" : "";
                byte[] data = Encoding.UTF8.GetBytes(String.Format(pageData, pageViews, disableSubmit));
                resp.ContentType = "text/html";
                resp.ContentEncoding = Encoding.UTF8;
                resp.ContentLength64 = data.LongLength;

                // Write out to the response stream (asynchronously), then close it
                await resp.OutputStream.WriteAsync(data, 0, data.Length);
                resp.Close();
            }
        }


        public void subain()
        {
            Console.WriteLine("Opening Server...");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1200);
            Console.WriteLine("Server Address:");
            Console.WriteLine("   127.0.0.1:9999");
            Console.WriteLine("   0.0.0.0:9999");
            Console.WriteLine("   localhost:9999");
            Console.WriteLine("");
            // Create a Http server and start listening for incoming connections
            listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();
            Console.WriteLine("Listening for connections on {0}", url);
            WebComd();

            // Handle requests
            Task listenTask = HandleIncomingConnections();
            listenTask.GetAwaiter().GetResult();

            // Close the listener
            listener.Close();
        }

        public void WebComd()
        {
            Console.WriteLine("");
            Console.Write(">> ");
            string WebCmd = Console.ReadLine();

            if (WebCmd == "")
            {
                WebComd();
            }
            if (WebCmd == "sh off server")
            {
                Console.WriteLine("Stopping Server...");
                webserver ws = new webserver();
                bool runServer = false;
                Main main = new Main();
                Console.WriteLine("");
                main.Commands();
            }
        }
    }
}









/*
 *Developed by NineJuan
 *Designed by NineJuan
 *copyrights on NineJuan
 *All rights Reserved
 *https://github.com/john0128/NjOtter/
 */