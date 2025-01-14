﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserHub.Application.Providers
{
    public interface IEmailValidatorProvider : IProvider
    {
        Task<bool> IsEmailValid(string email);


    }
}