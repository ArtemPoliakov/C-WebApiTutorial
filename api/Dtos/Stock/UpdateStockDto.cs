using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class UpdateStockDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol can not be over 1o characters")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(30, ErrorMessage = "Company name can not be over 30 characters")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(1, 1_000_000_000_000)]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Industry can not be over 1o characters")]
        public string Industry { get; set; } = string.Empty;
        [Required]
        [Range(1, 5_000_000_000_000)]
        public long MarketCap { get; set; }
    }
}