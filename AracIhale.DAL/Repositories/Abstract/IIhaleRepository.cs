﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IIhaleRepository : IRepository<Ihale>
    {
        List<IhaleListVM> IhaleListele(String ihaleAdi, KullaniciTipVM kTip, StatuVM statu);
    }
}
