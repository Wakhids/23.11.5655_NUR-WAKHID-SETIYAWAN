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
    [Table("m_header_nota")]
    public class HeaderNota
    {
        [ExplicitKey]
        [Display(Name = "header_nota_id")]
        public string header_nota_id { get; set; }

        [Display(Name = "Keterangan Header")]
        public string keterangan { get; set; }

        [Write(false)]
        [Display(Name = "order_number")]
        public int order_number { get; set; }

        [Write(false)]
        [Display(Name = "is_active")]
        public bool is_active { get; set; }
    }

    public class HeaderNotaValidator : AbstractValidator<HeaderNota>
    {
        public HeaderNotaValidator()
        {
            CascadeMode = FluentValidation.CascadeMode.StopOnFirstFailure;

            var msgError = "Inputan '{PropertyName}' maksimal {MaxLength} karakter !";

            RuleFor(c => c.keterangan).Length(0, 100).WithMessage(msgError);
        }
    }
}