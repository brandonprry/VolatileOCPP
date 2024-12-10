# ocpp.citrineos.Model.SmartchargingGetChargingProfilesBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomData** | [**CustomDataType**](CustomDataType.md) |  | [optional] 
**RequestId** | **int?** | Reference identification that is to be used by the Charging Station in the &amp;lt;&amp;lt;reportchargingprofilesrequest, ReportChargingProfilesRequest&amp;gt;&amp;gt; when provided.   | 
**EvseId** | **int?** | For which EVSE installed charging profiles SHALL be reported. If 0, only charging profiles installed on the Charging Station itself (the grid connection) SHALL be reported. If omitted, all installed charging profiles SHALL be reported.   | [optional] 
**ChargingProfile** | [**ChargingProfileCriterionType**](ChargingProfileCriterionType.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

