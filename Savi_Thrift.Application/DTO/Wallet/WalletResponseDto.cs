﻿

using Savi_Thrift.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savi_Thrift.Application.DTO.Wallet
{
    public class WalletResponseDto
    {
        public string WalletNumber { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public Currency Currency { get; set; } 
    }
}
