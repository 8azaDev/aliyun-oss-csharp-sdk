using Aliyun.OSS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace aliyun_oss_csharp_sdk_netcore_test
{
    [TestClass]
    public class OssClientTest
    {
        OssClient ossClient = new OssClient(endpoint: "", accessKeyId: "", accessKeySecret: "");
        [TestMethod]
        public void TestMethod1()
        {
            var data = ossClient.PutObject("", "", "");
        }

        [TestMethod]
        public void MyTestMethod()
        {
            var d = ossClient.GetObject("", "");

            byte[] buffer = new byte[d.ContentLength];
            d.Content.Read(buffer, 0, (int)d.Content.Length);

            var STR = System.Text.Encoding.UTF8.GetString(buffer);
        }
    }
}
