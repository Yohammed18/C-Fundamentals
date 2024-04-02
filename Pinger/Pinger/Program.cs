//bring in the data type
//Pinging Google DNS Server 8.8.8.8

//Other publick DNS server 208.67.222.222 and 208.67.220.220 (OpenDNS)
//1.1.1.1 and 1.0.0.1 (Cloudflare)
//8.8.8.8 and 8.8.4.4 (Google DNS)

//Module that contains various classes. Ping is one of those classes.
using System.Net.NetworkInformation;
using System.Text;

// by instentiating you're creating an object of type Ping that will be use to create our program.
Ping pingSender = new Ping();
PingOptions options = new PingOptions();

options.DontFragment = true;

//this will be the data that will be pass to the next computer
string data = "Learn to code";
byte[] buffer = Encoding.ASCII.GetBytes(data);
int timeout = 120;
string address = "8.8.8.8";
PingReply reply = pingSender.Send(address, timeout, buffer, options);

if (reply.Status == IPStatus.Success)
{
    Console.WriteLine("Response: {0}", reply.Status.ToString());
    Console.WriteLine("RoundTrip: {0}", reply.RoundtripTime);
    Console.WriteLine("Time to live: {0}", reply.Options);
    Console.WriteLine("Buffer Size: {0}", reply.Buffer.Length);
}