﻿//Interneuron Synapse

//Copyright(C) 2021  Interneuron CIC

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

//See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.If not, see<http://www.gnu.org/licenses/>.


﻿using System;
using System.Collections.Generic;

namespace Interneuron.CareRecord.Model.DomainModels
{
    public partial class baseview_ClinicalsummaryLabresults : Interneuron.CareRecord.Infrastructure.Domain.EntityBase
    {
        public string Observationidentifiertext { get; set; }
        public string ResultId { get; set; }
        public string PersonId { get; set; }
        public string OrderId { get; set; }
        public string Observationdate { get; set; }
        public string Observationtime { get; set; }
        public DateTime? Observationdatetime { get; set; }
        public string Observationidentifiercode { get; set; }
        public string Observationvalue { get; set; }
        public string Referencerangelow { get; set; }
        public string Referencerangehigh { get; set; }
        public string Unitstext { get; set; }
        public string Abnormalflag { get; set; }
        public string Rangelevel { get; set; }
    }
}
