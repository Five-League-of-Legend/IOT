using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Core.Model
{
    /// <summary>
    /// 团购
    /// </summary>
    public class GroupPurchase
    {
        public int GPId             { get; set; }
        public int IsGroup          { get; set; }
        public string Notice           { get; set; }
        public string CloseTime        { get; set; }
        public string PosterOne        { get; set; }
        public string PosterTwo        { get; set; }
        public string PosterThree      { get; set; }
        public string DespatchMode     { get; set; }
        public string HeadName         { get; set; }
        public decimal CoverageArea     { get; set; }
        public decimal ServiceCharge    { get; set; }
        public decimal WithdrawDeposit  { get; set; }
        public decimal Commission       { get; set; }
    }
}
