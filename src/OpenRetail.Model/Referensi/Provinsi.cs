/**
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

using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace OpenRetail.Model
{
    [Table("m_provinsi2")]
    public class Provinsi
    {
        [ExplicitKey]
        [Display(Name = "provinsi_id")]
        public string provinsi_id { get; set; }

        [Display(Name = "nama_provinsi")]
        public string nama_provinsi { get; set; }
    }

    public class ProvinsiValidator : AbstractValidator<Provinsi>
    {
        public ProvinsiValidator()
        {
            CascadeMode = FluentValidation.CascadeMode.StopOnFirstFailure;

            var msgError1 = "'{PropertyName}' tidak boleh kosong !";
            var msgError2 = "Inputan '{PropertyName}' maksimal {MaxLength} karakter !";

            RuleFor(c => c.nama_provinsi).NotEmpty().WithMessage(msgError1).Length(1, 250).WithMessage(msgError2);
        }
    }
}