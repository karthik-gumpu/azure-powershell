---
external help file:
Module Name: Az.Network
online version: https://learn.microsoft.com/powershell/module/az.network/get-aznetworksecurityperimeterprofile
schema: 2.0.0
---

# Get-AzNetworkSecurityPerimeterProfile

## SYNOPSIS
Gets the specified NSP profile.

## SYNTAX

### List (Default)
```
Get-AzNetworkSecurityPerimeterProfile -ResourceGroupName <String> -SecurityPerimeterName <String>
 [-SubscriptionId <String[]>] [-SkipToken <String>] [-Top <Int32>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### Get
```
Get-AzNetworkSecurityPerimeterProfile -Name <String> -ResourceGroupName <String>
 -SecurityPerimeterName <String> [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzNetworkSecurityPerimeterProfile -InputObject <INetworkSecurityPerimeterIdentity>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentityNetworkSecurityPerimeter
```
Get-AzNetworkSecurityPerimeterProfile -Name <String>
 -NetworkSecurityPerimeterInputObject <INetworkSecurityPerimeterIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Gets the specified NSP profile.

## EXAMPLES

### Example 1: Gets a NetworkSecurityPerimeterProfile by Name
```powershell

 Get-AzNetworkSecurityPerimeterProfile -ResourceGroupName ResourceGroup-1 -SecurityPerimeterName nsp3

```

```output

Location    Name
--------    ----
eastus2euap profile1
eastus2euap profile2


```

Lists NetworkSecurityPerimeterProfile

### Example 2: Gets a NetworkSecurityPerimeterProfile by Name
```powershell

 Get-AzNetworkSecurityPerimeterProfile -Name profile1 -ResourceGroupName ResourceGroup-1 -SecurityPerimeterName nsp3

```

```output

Location    Name
--------    ----
eastus2euap profile1


```

Gets a NetworkSecurityPerimeterProfile by Name

### Example 3: Gets a NetworkSecurityPerimeterProfile by identity (using pipe)
```powershell

 $GETObj = Get-AzNetworkSecurityPerimeterProfile -Name profile1 -ResourceGroupName ResourceGroup-1 -SecurityPerimeterName nsp3
 Get-AzNetworkSecurityPerimeterProfile -InputObject $GETObj

```

```output

Location    Name
--------    ----
eastus2euap profile1


```

Gets a NetworkSecurityPerimeterProfile by identity (using pipe)

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the NSP profile.

```yaml
Type: System.String
Parameter Sets: Get, GetViaIdentityNetworkSecurityPerimeter
Aliases: ProfileName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkSecurityPerimeterInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity
Parameter Sets: GetViaIdentityNetworkSecurityPerimeter
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityPerimeterName
The name of the network security perimeter.

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases: NetworkSecurityPerimeterName, NSPName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkipToken
SkipToken is only used if a previous operation returned a partial result.
If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The subscription credentials which uniquely identify the Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String[]
Parameter Sets: Get, List
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
An optional query parameter which specifies the maximum number of records to be returned by the server.

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INspProfile

## NOTES

## RELATED LINKS

