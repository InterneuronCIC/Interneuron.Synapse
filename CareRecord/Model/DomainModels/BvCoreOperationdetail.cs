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
    public partial class baseview_BvCoreOperationdetail : Interneuron.CareRecord.Infrastructure.Domain.EntityBase
    {
        public string OperationId { get; set; }
        public string RowId { get; set; }
        public int? Sequenceid { get; set; }
        public string Contextkey { get; set; }
        public DateTime? Createdtimestamp { get; set; }
        public DateTime? Createddate { get; set; }
        public string Createdsource { get; set; }
        public string Createdmessageid { get; set; }
        public string Createdby { get; set; }
        public short? Recordstatus { get; set; }
        public string Timezonename { get; set; }
        public int? Timezoneoffset { get; set; }
        public string Tenant { get; set; }
        public string PersonId { get; set; }
        public string EncounterId { get; set; }
        public string LocationId { get; set; }
        public string Statuscode { get; set; }
        public string Statustext { get; set; }
        public string Operationtypecode { get; set; }
        public string Operationtypetext { get; set; }
        public string Scheduleidentifiercode { get; set; }
        public string Scheduleidentifiertext { get; set; }
        public string Reasoncode { get; set; }
        public string Reasontext { get; set; }
        public decimal? Operationduration { get; set; }
        public string Operationdurationunit { get; set; }
        public DateTime? Plannedstart { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }
        public string Operationsidecode { get; set; }
        public string Operationsidetext { get; set; }
        public string Operationnotestatuscode { get; set; }
        public string Operationnotestatustext { get; set; }
        public string Operationqualifiercode { get; set; }
        public string Operationqualifiertext { get; set; }
    }
}