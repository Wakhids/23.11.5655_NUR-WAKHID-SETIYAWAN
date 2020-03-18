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

using OpenRetail.Model.Report;
using System;
using System.Collections.Generic;

namespace OpenRetail.Bll.Api.Report
{
    public interface IReportPiutangJualProdukBll : IBaseReportBll<ReportPiutangPenjualanProdukHeader>
    {
        IList<ReportPiutangPenjualanProdukDetail> DetailGetByBulan(int bulan, int tahun);

        IList<ReportPiutangPenjualanProdukDetail> DetailGetByBulan(int bulanAwal, int bulanAkhir, int tahun);

        IList<ReportPiutangPenjualanProdukDetail> DetailGetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai);

        IList<ReportPiutangPenjualanProduk> PerProdukGetByBulan(int bulan, int tahun);

        IList<ReportPiutangPenjualanProduk> PerProdukGetByBulan(int bulanAwal, int bulanAkhir, int tahun);

        IList<ReportPiutangPenjualanProduk> PerProdukGetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai);
    }
}