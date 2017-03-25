﻿/**
 * Copyright (C) 2017 Kamarudin (http://coding4ever.net/)
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 *
 * The latest version of this file can be found at https://github.com/rudi-krsoftware/open-retail
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using log4net;
using OpenRetail.Model.Report;
using OpenRetail.Bll.Api.Report;
using OpenRetail.Repository.Api;
using OpenRetail.Repository.Service;

namespace OpenRetail.Bll.Service.Report
{
    public class ReportStokProdukBll : IReportStokProdukBll
    {
        private ILog _log;

        public ReportStokProdukBll(ILog log)
        {
            _log = log;
        }
        
        public IList<ReportStokProduk> GetStokByStatus(StatusStok statusStok)
        {
            IList<ReportStokProduk> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                IUnitOfWork uow = new UnitOfWork(context, _log);
                oList = uow.ReportStokProdukRepository.GetStokByStatus(statusStok);
            }

            return oList;
        }
        
        public IList<ReportPenyesuaianStokProduk> GetPenyesuaianStokByBulan(int bulan, int tahun)
        {
            IList<ReportPenyesuaianStokProduk> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                IUnitOfWork uow = new UnitOfWork(context, _log);
                oList = uow.ReportStokProdukRepository.GetPenyesuaianStokByBulan(bulan, tahun);
            }

            return oList;
        }

        public IList<ReportPenyesuaianStokProduk> GetPenyesuaianStokByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai)
        {
            IList<ReportPenyesuaianStokProduk> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                IUnitOfWork uow = new UnitOfWork(context, _log);
                oList = uow.ReportStokProdukRepository.GetPenyesuaianStokByTanggal(tanggalMulai, tanggalSelesai);
            }

            return oList;
        }
    }
}