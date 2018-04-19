using Aliyun.OSS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace aliyun_oss_csharp_sdk_netcore_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ossClient = new OssClient("sdfsdfsdf", "invalidKeyId", "sdfsdfsdf");

           var data=  ossClient.GetObject("sdfs", "sdfsdf");
        }
    }
}
