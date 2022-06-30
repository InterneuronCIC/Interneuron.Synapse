//BEGIN LICENSE BLOCK 
//Interneuron Synapse

//Copyright(C) 2022  Interneuron CIC

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
//END LICENSE BLOCK 
﻿export class ValidationResult {
    result: boolean;
    errorMsg: string;

    constructor(result: boolean, errormsg?: string) {
        this.result = result;
        this.errorMsg = errormsg;
    }

    concat(result: ValidationResult): void {
        this.result = this.result && result.result;
        if (!result.result)
            if (this.errorMsg != undefined)
                this.errorMsg += result.errorMsg + document.createElement("br").outerHTML;
            else
                this.errorMsg = result.errorMsg + document.createElement("br").outerHTML;
    }
}