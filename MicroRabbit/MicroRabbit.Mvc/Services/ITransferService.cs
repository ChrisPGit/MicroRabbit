using MicroRabbit.Mvc.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Mvc.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto transferDto);
    }
}
