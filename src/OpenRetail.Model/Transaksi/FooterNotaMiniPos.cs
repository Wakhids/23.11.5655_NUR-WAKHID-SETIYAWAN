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
    [Table("m_footer_nota_mini_pos")]
    public class FooterNotaMiniPos
    {
        [ExplicitKey]
        [Display(Name = "footer_nota_id")]
        public string footer_nota_id { get; set; }

        [Display(Name = "Keterangan Footer")]
        public string keterangan { get; set; }

        [Write(false)]
        [Display(Name = "order_number")]
        public int order_number { get; set; }

        [Write(false)]
        [Display(Name = "is_active")]
        public bool is_active { get; set; }
    }

    public class FooterNotaMiniPosValidator : AbstractValidator<FooterNotaMiniPos>
    {
        public FooterNotaMiniPosValidator()
        {
            CascadeMode = FluentValidation.CascadeMode.StopOnFirstFailure;

            var msgError = "Inputan '{PropertyName}' maksimal {MaxLength} karakter !";

            RuleFor(c => c.keterangan).Length(0, 40).WithMessage(msgError);
        }
    }
}