using System.ComponentModel.DataAnnotations;

namespace TokenPay.Domains
{
    public class Tokens
    {
        [Key]
        public string Id { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 密钥
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// TRX余额
        /// </summary>
        public decimal Trx { get; set; }
        /// <summary>
        /// USDT余额
        /// </summary>
        public decimal USDT { get; set; }
    }
}