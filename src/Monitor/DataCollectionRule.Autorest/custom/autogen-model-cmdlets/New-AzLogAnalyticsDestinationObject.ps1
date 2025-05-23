
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for LogAnalyticsDestination.
.Description
Create an in-memory object for LogAnalyticsDestination.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.LogAnalyticsDestination
.Link
https://learn.microsoft.com/powershell/module/Az.Monitor/new-azloganalyticsdestinationobject
#>
function New-AzLogAnalyticsDestinationObject {
    [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.ModelCmdletAttribute()]
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.LogAnalyticsDestination')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="A friendly name for the destination.
        This name should be unique across all destinations (regardless of type) within the data collection rule.")]
        [string]
        $Name,
        [Parameter(HelpMessage="The resource ID of the Log Analytics workspace.")]
        [string]
        $WorkspaceResourceId
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.LogAnalyticsDestination]::New()

        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.Name = $Name
        }
        if ($PSBoundParameters.ContainsKey('WorkspaceResourceId')) {
            $Object.WorkspaceResourceId = $WorkspaceResourceId
        }
        return $Object
    }
}

