# ocpp.citrineos.Model.SmartchargingGetCompositeScheduleBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomData** | [**CustomDataType**](CustomDataType.md) |  | [optional] 
**Duration** | **int?** | Length of the requested schedule in seconds.     | 
**ChargingRateUnit** | [**ChargingRateUnitEnumType**](ChargingRateUnitEnumType.md) |  | [optional] 
**EvseId** | **int?** | The ID of the EVSE for which the schedule is requested. When evseid&#x3D;0, the Charging Station will calculate the expected consumption for the grid connection.   | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

