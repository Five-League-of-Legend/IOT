using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Model
{
    /// <summary>
    /// 小程序
    /// </summary>
    public class MiniProgram
    {
        public int procedureid     { get; set; }
        public string APPID           { get; set; }
        public string SECRET          { get; set; }
        public int MerchantCode    { get; set; }
        public string SecretKey       { get; set; }
        public string CertificateCERT { get; set; }
        public string CertificateKEY  { get; set; }
        public string Payment         { get; set; }
    }
}
