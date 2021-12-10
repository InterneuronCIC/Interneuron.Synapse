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


using System;
using System.Collections.Generic;

namespace Interneuron.CareRecord.Model.DomainModels
{
    public partial class entitystorematerialised_CoreOrder1 : Interneuron.CareRecord.Infrastructure.Domain.EntityBase
    {
        public string OrderId { get; set; }
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
        public DateTime? Datetimeoftransaction { get; set; }
        public string Diagnosticserviceid { get; set; }
        public string Fillerordernumber { get; set; }
        public DateTime? Observationdatetime { get; set; }
        public DateTime? Observationenddatetime { get; set; }
        public string Ordercontrol { get; set; }
        public DateTime? Ordereffectivedate { get; set; }
        public string Ordernotes { get; set; }
        public string Orderstatus { get; set; }
        public string Placerordernumber { get; set; }
        public string Relevantclinicalinfo { get; set; }
        public DateTime? Requesteddatetime { get; set; }
        public string Resultstatus { get; set; }
        public int? Setid { get; set; }
        public DateTime? Specimendatetime { get; set; }
        public string Specimentypecode { get; set; }
        public string Specimentypetext { get; set; }
        public string Specimentypecodingsystem { get; set; }
        public DateTime? Statuschangedatetime { get; set; }
        public string Universalservicecode { get; set; }
        public string Universalservicetext { get; set; }
        public string Orderingprovider { get; set; }
        public string Universalservicecodingsystem { get; set; }
    }
}