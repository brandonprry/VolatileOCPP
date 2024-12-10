#!/usr/bin/env python2

messages = [
    [
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "CancelReservation",
  {
    "customData": {
      "vendorId": "string"
    },
    "reservationId": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "CertificateSigned",
  {
    "customData": {
      "vendorId": "string"
    },
    "certificateChain": "string",
    "certificateType": "ChargingStationCertificate"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ClearCache",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ClearChargingProfile",
  {
    "customData": {
      "vendorId": "string"
    },
    "chargingProfileId": 0,
    "chargingProfileCriteria": {
      "customData": {
        "vendorId": "string"
      },
      "evseId": 0,
      "chargingProfilePurpose": "ChargingStationExternalConstraints",
      "stackLevel": 0
    }
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ClearDisplayMessage",
  {
    "customData": {
      "vendorId": "string"
    },
    "id": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ClearVariableMonitoring",
  {
    "customData": {
      "vendorId": "string"
    },
    "id": [
      0
    ]
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ClearedChargingLimit",
  {
    "customData": {
      "vendorId": "string"
    },
    "chargingLimitSource": "EMS",
    "evseId": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "CostUpdated",
  {
    "customData": {
      "vendorId": "string"
    },
    "totalCost": 0,
    "transactionId": "string"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "CustomerInformation",
  {
    "customData": {
      "vendorId": "string"
    },
    "customerCertificate": {
      "customData": {
        "vendorId": "string"
      },
      "hashAlgorithm": "SHA256",
      "issuerNameHash": "string",
      "issuerKeyHash": "string",
      "serialNumber": "string"
    },
    "idToken": {
      "customData": {
        "vendorId": "string"
      },
      "additionalInfo": [
        {
          "customData": {
            "vendorId": "string"
          },
          "additionalIdToken": "string",
          "type": "string"
        }
      ],
      "idToken": "string",
      "type": "Central"
    },
    "requestId": 0,
    "report": True,
    "clear": True,
    "customerIdentifier": "string"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "DeleteCertificate",
  {
    "customData": {
      "vendorId": "string"
    },
    "certificateHashData": {
      "customData": {
        "vendorId": "string"
      },
      "hashAlgorithm": "SHA256",
      "issuerNameHash": "string",
      "issuerKeyHash": "string",
      "serialNumber": "string"
    }
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "Get15118EVCertificate",
  {
    "customData": {
      "vendorId": "string"
    },
    "iso15118SchemaVersion": "string",
    "action": "Install",
    "exiRequest": "string"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetBaseReport",
  {
    "customData": {
      "vendorId": "string"
    },
    "requestId": 0,
    "reportBase": "ConfigurationInventory"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetCertificateStatus",
  {
    "customData": {
      "vendorId": "string"
    },
    "ocspRequestData": {
      "customData": {
        "vendorId": "string"
      },
      "hashAlgorithm": "SHA256",
      "issuerNameHash": "string",
      "issuerKeyHash": "string",
      "serialNumber": "string",
      "responderURL": "string"
    }
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetChargingProfiles",
  {
    "customData": {
      "vendorId": "string"
    },
    "requestId": 0,
    "evseId": 0,
    "chargingProfile": {
      "customData": {
        "vendorId": "string"
      },
      "chargingProfilePurpose": "ChargingStationExternalConstraints",
      "stackLevel": 0,
      "chargingProfileId": [
        0
      ],
      "chargingLimitSource": [
        "EMS"
      ]
    }
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetDisplayMessages",
  {
    "customData": {
      "vendorId": "string"
    },
    "id": [
      0
    ],
    "requestId": 0,
    "priority": "AlwaysFront",
    "state": "Charging"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetInstalledCertificateIds",
  {
    "customData": {
      "vendorId": "string"
    },
    "certificateType": [
      "V2GRootCertificate"
    ]
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetLog",
  {
    "customData": {
      "vendorId": "string"
    },
    "log": {
      "customData": {
        "vendorId": "string"
      },
      "remoteLocation": "string",
      "oldestTimestamp": "2019-08-24T14:15:22Z",
      "latestTimestamp": "2019-08-24T14:15:22Z"
    },
    "logType": "DiagnosticsLog",
    "requestId": 0,
    "retries": 0,
    "retryInterval": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetMonitoringReport",
  {
    "customData": {
      "vendorId": "string"
    },
    "componentVariable": [
      {
        "customData": {
          "vendorId": "string"
        },
        "component": {
          "customData": {
            "vendorId": "string"
          },
          "evse": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "connectorId": 0
          },
          "name": "string",
          "instance": "string"
        },
        "variable": {
          "customData": {
            "vendorId": "string"
          },
          "name": "string",
          "instance": "string"
        }
      }
    ],
    "requestId": 0,
    "monitoringCriteria": [
      "ThresholdMonitoring"
    ]
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetReport",
  {
    "customData": {
      "vendorId": "string"
    },
    "componentVariable": [
      {
        "customData": {
          "vendorId": "string"
        },
        "component": {
          "customData": {
            "vendorId": "string"
          },
          "evse": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "connectorId": 0
          },
          "name": "string",
          "instance": "string"
        },
        "variable": {
          "customData": {
            "vendorId": "string"
          },
          "name": "string",
          "instance": "string"
        }
      }
    ],
    "requestId": 0,
    "componentCriteria": [
      "Active"
    ]
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetTransactionStatus",
  {
    "customData": {
      "vendorId": "string"
    },
    "transactionId": "string"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetVariables",
  {
    "customData": {
      "vendorId": "string"
    },
    "getVariableData": [
      {
        "customData": {
          "vendorId": "string"
        },
        "attributeType": "Actual",
        "component": {
          "customData": {
            "vendorId": "string"
          },
          "evse": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "connectorId": 0
          },
          "name": "string",
          "instance": "string"
        },
        "variable": {
          "customData": {
            "vendorId": "string"
          },
          "name": "string",
          "instance": "string"
        }
      }
    ]
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "InstallCertificate",
  {
    "customData": {
      "vendorId": "string"
    },
    "certificateType": "V2GRootCertificate",
    "certificate": "string"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "LogStatusNotification",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "BadMessage",
    "requestId": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyChargingLimit",
  {
    "customData": {
      "vendorId": "string"
    },
    "chargingSchedule": [
      {
        "customData": {
          "vendorId": "string"
        },
        "id": 0,
        "startSchedule": "2019-08-24T14:15:22Z",
        "duration": 0,
        "chargingRateUnit": "W",
        "chargingSchedulePeriod": [
          {
            "customData": {
              "vendorId": "string"
            },
            "startPeriod": 0,
            "limit": 0,
            "numberPhases": 0,
            "phaseToUse": 0
          }
        ],
        "minChargingRate": 0,
        "salesTariff": {
          "customData": {
            "vendorId": "string"
          },
          "id": 0,
          "salesTariffDescription": "string",
          "numEPriceLevels": 0,
          "salesTariffEntry": [
            {
              "customData": {
                "vendorId": "string"
              },
              "relativeTimeInterval": {
                "customData": {
                  "vendorId": "string"
                },
                "start": 0,
                "duration": 0
              },
              "ePriceLevel": 0,
              "consumptionCost": [
                {
                  "customData": {},
                  "startValue": 0,
                  "cost": [
                    {}
                  ]
                }
              ]
            }
          ]
        }
      }
    ],
    "evseId": 0,
    "chargingLimit": {
      "customData": {
        "vendorId": "string"
      },
      "chargingLimitSource": "EMS",
      "isGridCritical": True
    }
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyCustomerInformation",
  {
    "customData": {
      "vendorId": "string"
    },
    "data": "string",
    "tbc": False,
    "seqNo": 0,
    "generatedAt": "2019-08-24T14:15:22Z",
    "requestId": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyDisplayMessages",
  {
    "customData": {
      "vendorId": "string"
    },
    "messageInfo": [
      {
        "customData": {
          "vendorId": "string"
        },
        "display": {
          "customData": {
            "vendorId": "string"
          },
          "evse": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "connectorId": 0
          },
          "name": "string",
          "instance": "string"
        },
        "id": 0,
        "priority": "AlwaysFront",
        "state": "Charging",
        "startDateTime": "2019-08-24T14:15:22Z",
        "endDateTime": "2019-08-24T14:15:22Z",
        "transactionId": "string",
        "message": {
          "customData": {
            "vendorId": "string"
          },
          "format": "ASCII",
          "language": "string",
          "content": "string"
        }
      }
    ],
    "requestId": 0,
    "tbc": False
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyEVChargingNeeds",
  {
    "customData": {
      "vendorId": "string"
    },
    "maxScheduleTuples": 0,
    "chargingNeeds": {
      "customData": {
        "vendorId": "string"
      },
      "acChargingParameters": {
        "customData": {
          "vendorId": "string"
        },
        "energyAmount": 0,
        "evMinCurrent": 0,
        "evMaxCurrent": 0,
        "evMaxVoltage": 0
      },
      "dcChargingParameters": {
        "customData": {
          "vendorId": "string"
        },
        "evMaxCurrent": 0,
        "evMaxVoltage": 0,
        "energyAmount": 0,
        "evMaxPower": 0,
        "stateOfCharge": 100,
        "evEnergyCapacity": 0,
        "fullSoC": 100,
        "bulkSoC": 100
      },
      "requestedEnergyTransfer": "DC",
      "departureTime": "2019-08-24T14:15:22Z"
    },
    "evseId": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyEVChargingSchedule",
  {
    "customData": {
      "vendorId": "string"
    },
    "timeBase": "2019-08-24T14:15:22Z",
    "chargingSchedule": {
      "customData": {
        "vendorId": "string"
      },
      "id": 0,
      "startSchedule": "2019-08-24T14:15:22Z",
      "duration": 0,
      "chargingRateUnit": "W",
      "chargingSchedulePeriod": [
        {
          "customData": {
            "vendorId": "string"
          },
          "startPeriod": 0,
          "limit": 0,
          "numberPhases": 0,
          "phaseToUse": 0
        }
      ],
      "minChargingRate": 0,
      "salesTariff": {
        "customData": {
          "vendorId": "string"
        },
        "id": 0,
        "salesTariffDescription": "string",
        "numEPriceLevels": 0,
        "salesTariffEntry": [
          {
            "customData": {
              "vendorId": "string"
            },
            "relativeTimeInterval": {
              "customData": {
                "vendorId": "string"
              },
              "start": 0,
              "duration": 0
            },
            "ePriceLevel": 0,
            "consumptionCost": [
              {
                "customData": {
                  "vendorId": "string"
                },
                "startValue": 0,
                "cost": [
                  {
                    "customData": {}
                  }
                ]
              }
            ]
          }
        ]
      }
    },
    "evseId": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyEvent",
  {
    "customData": {
      "vendorId": "string"
    },
    "generatedAt": "2019-08-24T14:15:22Z",
    "tbc": False,
    "seqNo": 0,
    "eventData": [
      {
        "customData": {
          "vendorId": "string"
        },
        "eventId": 0,
        "timestamp": "2019-08-24T14:15:22Z",
        "trigger": "Alerting",
        "cause": 0,
        "actualValue": "string",
        "techCode": "string",
        "techInfo": "string",
        "cleared": True,
        "transactionId": "string",
        "component": {
          "customData": {
            "vendorId": "string"
          },
          "evse": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "connectorId": 0
          },
          "name": "string",
          "instance": "string"
        },
        "variableMonitoringId": 0,
        "eventNotificationType": "HardWiredNotification",
        "variable": {
          "customData": {
            "vendorId": "string"
          },
          "name": "string",
          "instance": "string"
        }
      }
    ]
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyMonitoringReport",
  {
    "customData": {
      "vendorId": "string"
    },
    "monitor": [
      {
        "customData": {
          "vendorId": "string"
        },
        "component": {
          "customData": {
            "vendorId": "string"
          },
          "evse": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "connectorId": 0
          },
          "name": "string",
          "instance": "string"
        },
        "variable": {
          "customData": {
            "vendorId": "string"
          },
          "name": "string",
          "instance": "string"
        },
        "variableMonitoring": [
          {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "transaction": True,
            "value": 0,
            "type": "UpperThreshold",
            "severity": 0
          }
        ]
      }
    ],
    "requestId": 0,
    "tbc": False,
    "seqNo": 0,
    "generatedAt": "2019-08-24T14:15:22Z"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyReport",
  {
    "customData": {
      "vendorId": "string"
    },
    "requestId": 0,
    "generatedAt": "2019-08-24T14:15:22Z",
    "reportData": [
      {
        "customData": {
          "vendorId": "string"
        },
        "component": {
          "customData": {
            "vendorId": "string"
          },
          "evse": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "connectorId": 0
          },
          "name": "string",
          "instance": "string"
        },
        "variable": {
          "customData": {
            "vendorId": "string"
          },
          "name": "string",
          "instance": "string"
        },
        "variableAttribute": [
          {
            "customData": {
              "vendorId": "string"
            },
            "type": "Actual",
            "value": "string",
            "mutability": "ReadOnly",
            "persistent": False,
            "constant": False
          }
        ],
        "variableCharacteristics": {
          "customData": {
            "vendorId": "string"
          },
          "unit": "string",
          "dataType": "string",
          "minLimit": 0,
          "maxLimit": 0,
          "valuesList": "string",
          "supportsMonitoring": True
        }
      }
    ],
    "tbc": False,
    "seqNo": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "PublishFirmware",
  {
    "customData": {
      "vendorId": "string"
    },
    "location": "string",
    "retries": 0,
    "checksum": "string",
    "requestId": 0,
    "retryInterval": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "PublishFirmwareStatusNotification",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Idle",
    "location": [
      "string"
    ],
    "requestId": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ReportChargingProfiles",
  {
    "customData": {
      "vendorId": "string"
    },
    "requestId": 0,
    "chargingLimitSource": "EMS",
    "chargingProfile": [
      {
        "customData": {
          "vendorId": "string"
        },
        "id": 0,
        "stackLevel": 0,
        "chargingProfilePurpose": "ChargingStationExternalConstraints",
        "chargingProfileKind": "Absolute",
        "recurrencyKind": "Daily",
        "validFrom": "2019-08-24T14:15:22Z",
        "validTo": "2019-08-24T14:15:22Z",
        "chargingSchedule": [
          {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "startSchedule": "2019-08-24T14:15:22Z",
            "duration": 0,
            "chargingRateUnit": "W",
            "chargingSchedulePeriod": [
              {
                "customData": {
                  "vendorId": "string"
                },
                "startPeriod": 0,
                "limit": 0,
                "numberPhases": 0,
                "phaseToUse": 0
              }
            ],
            "minChargingRate": 0,
            "salesTariff": {
              "customData": {
                "vendorId": "string"
              },
              "id": 0,
              "salesTariffDescription": "string",
              "numEPriceLevels": 0,
              "salesTariffEntry": [
                {
                  "customData": {},
                  "relativeTimeInterval": {
                    "customData": {}
                  },
                  "ePriceLevel": 0,
                  "consumptionCost": [
                    {}
                  ]
                }
              ]
            }
          }
        ],
        "transactionId": "string"
      }
    ],
    "tbc": False,
    "evseId": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "StartTransactionRequest",
  {
    "customData": {
      "vendorId": "string"
    },
    "evseId": 0,
    "groupIdToken": {
      "customData": {
        "vendorId": "string"
      },
      "additionalInfo": [
        {
          "customData": {
            "vendorId": "string"
          },
          "additionalIdToken": "string",
          "type": "string"
        }
      ],
      "idToken": "string",
      "type": "Central"
    },
    "idToken": {
      "customData": {
        "vendorId": "string"
      },
      "additionalInfo": [
        {
          "customData": {
            "vendorId": "string"
          },
          "additionalIdToken": "string",
          "type": "string"
        }
      ],
      "idToken": "string",
      "type": "Central"
    },
    "remoteStartId": 0,
    "chargingProfile": {
      "customData": {
        "vendorId": "string"
      },
      "id": 0,
      "stackLevel": 0,
      "chargingProfilePurpose": "ChargingStationExternalConstraints",
      "chargingProfileKind": "Absolute",
      "recurrencyKind": "Daily",
      "validFrom": "2019-08-24T14:15:22Z",
      "validTo": "2019-08-24T14:15:22Z",
      "chargingSchedule": [
        {
          "customData": {
            "vendorId": "string"
          },
          "id": 0,
          "startSchedule": "2019-08-24T14:15:22Z",
          "duration": 0,
          "chargingRateUnit": "W",
          "chargingSchedulePeriod": [
            {
              "customData": {
                "vendorId": "string"
              },
              "startPeriod": 0,
              "limit": 0,
              "numberPhases": 0,
              "phaseToUse": 0
            }
          ],
          "minChargingRate": 0,
          "salesTariff": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "salesTariffDescription": "string",
            "numEPriceLevels": 0,
            "salesTariffEntry": [
              {
                "customData": {
                  "vendorId": "string"
                },
                "relativeTimeInterval": {
                  "customData": {},
                  "start": 0,
                  "duration": 0
                },
                "ePriceLevel": 0,
                "consumptionCost": [
                  {
                    "customData": {},
                    "cost": []
                  }
                ]
              }
            ]
          }
        }
      ],
      "transactionId": "string"
    }
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "StopTransactionRequest",
  {
    "customData": {
      "vendorId": "string"
    },
    "transactionId": "string"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ReservationStatusUpdate",
  {
    "customData": {
      "vendorId": "string"
    },
    "reservationId": 0,
    "reservationUpdateStatus": "Expired"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SecurityEventNotification",
  {
    "customData": {
      "vendorId": "string"
    },
    "type": "string",
    "timestamp": "2019-08-24T14:15:22Z",
    "techInfo": "string"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetDisplayMessage",
  {
    "customData": {
      "vendorId": "string"
    },
    "message": {
      "customData": {
        "vendorId": "string"
      },
      "display": {
        "customData": {
          "vendorId": "string"
        },
        "evse": {
          "customData": {
            "vendorId": "string"
          },
          "id": 0,
          "connectorId": 0
        },
        "name": "string",
        "instance": "string"
      },
      "id": 0,
      "priority": "AlwaysFront",
      "state": "Charging",
      "startDateTime": "2019-08-24T14:15:22Z",
      "endDateTime": "2019-08-24T14:15:22Z",
      "transactionId": "string",
      "message": {
        "customData": {
          "vendorId": "string"
        },
        "format": "ASCII",
        "language": "string",
        "content": "string"
      }
    }
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetMonitoringBase",
  {
    "customData": {
      "vendorId": "string"
    },
    "monitoringBase": "All"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetMonitoringLevel",
  {
    "customData": {
      "vendorId": "string"
    },
    "severity": 0
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetNetworkProfile",
  {
    "customData": {
      "vendorId": "string"
    },
    "configurationSlot": 0,
    "connectionData": {
      "customData": {
        "vendorId": "string"
      },
      "apn": {
        "customData": {
          "vendorId": "string"
        },
        "apn": "string",
        "apnUserName": "string",
        "apnPassword": "string",
        "simPin": 0,
        "preferredNetwork": "string",
        "useOnlyPreferredNetwork": False,
        "apnAuthentication": "CHAP"
      },
      "ocppVersion": "OCPP12",
      "ocppTransport": "JSON",
      "ocppCsmsUrl": "string",
      "messageTimeout": 0,
      "securityProfile": 0,
      "ocppInterface": "Wired0",
      "vpn": {
        "customData": {
          "vendorId": "string"
        },
        "server": "string",
        "user": "string",
        "group": "string",
        "password": "string",
        "key": "string",
        "type": "IKEv2"
      }
    }
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetVariableMonitoring",
  {
    "customData": {
      "vendorId": "string"
    },
    "setMonitoringData": [
      {
        "customData": {
          "vendorId": "string"
        },
        "id": 0,
        "transaction": False,
        "value": 0,
        "type": "UpperThreshold",
        "severity": 0,
        "component": {
          "customData": {
            "vendorId": "string"
          },
          "evse": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "connectorId": 0
          },
          "name": "string",
          "instance": "string"
        },
        "variable": {
          "customData": {
            "vendorId": "string"
          },
          "name": "string",
          "instance": "string"
        }
      }
    ]
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetVariables",
  {
    "customData": {
      "vendorId": "string"
    },
    "setVariableData": [
      {
        "customData": {
          "vendorId": "string"
        },
        "attributeType": "Actual",
        "attributeValue": "string",
        "component": {
          "customData": {
            "vendorId": "string"
          },
          "evse": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "connectorId": 0
          },
          "name": "string",
          "instance": "string"
        },
        "variable": {
          "customData": {
            "vendorId": "string"
          },
          "name": "string",
          "instance": "string"
        }
      }
    ]
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SignCertificate",
  {
    "customData": {
      "vendorId": "string"
    },
    "csr": "string",
    "certificateType": "ChargingStationCertificate"
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "TransactionEvent",
  {
    "customData": {
      "vendorId": "string"
    },
    "eventType": "Ended",
    "meterValue": [
      {
        "customData": {
          "vendorId": "string"
        },
        "sampledValue": [
          {
            "customData": {
              "vendorId": "string"
            },
            "value": 0,
            "context": "Interruption.Begin",
            "measurand": "Current.Export",
            "phase": "L1",
            "location": "Body",
            "signedMeterValue": {
              "customData": {
                "vendorId": "string"
              },
              "signedMeterData": "string",
              "signingMethod": "string",
              "encodingMethod": "string",
              "publicKey": "string"
            },
            "unitOfMeasure": {
              "customData": {
                "vendorId": "string"
              },
              "unit": "Wh",
              "multiplier": 0
            }
          }
        ],
        "timestamp": "2019-08-24T14:15:22Z"
      }
    ],
    "timestamp": "2019-08-24T14:15:22Z",
    "triggerReason": "Authorized",
    "seqNo": 0,
    "offline": False,
    "numberOfPhasesUsed": 0,
    "cableMaxCurrent": 0,
    "reservationId": 0,
    "transactionInfo": {
      "customData": {
        "vendorId": "string"
      },
      "transactionId": "string",
      "chargingState": "Charging",
      "timeSpentCharging": 0,
      "stoppedReason": "DeAuthorized",
      "remoteStartId": 0
    },
    "evse": {
      "customData": {
        "vendorId": "string"
      },
      "id": 0,
      "connectorId": 0
    },
    "idToken": {
      "customData": {
        "vendorId": "string"
      },
      "additionalInfo": [
        {
          "customData": {
            "vendorId": "string"
          },
          "additionalIdToken": "string",
          "type": "string"
        }
      ],
      "idToken": "string",
      "type": "Central"
    }
  }
],
[
  2,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "UnpublishFirmware",
  {
    "customData": {
      "vendorId": "string"
    },
    "checksum": "string"
  }
],
    [2,"852a4cb2-0e20-46f8-bc29-c5ab3cb182c7","BootNotification",{"chargePointVendor":"volatileocpp","chargePointModel":"Fuzzer", "imsi":"test", "chargePointSerialNumber":"test", "chargeBoxSerialNumber":"test", "firmwareVersion":"test","iccid":"test", "meterType":"test", "meterSerialNumber":"test"}],
    [2,"9b25cbb0-c016-41e7-baa0-e796a9565c11","StatusNotification",{"connectorId":"1","errorCode":"NoError","status":"Available"}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2c8b", "Heartbeat", {}],
    [2,"3786718","ChangeAvailability",{"connectorId":"1","type":"Inoperative"}],
    [2,"15455","CancelReservation",{"reservationId":"1"}],
    [2,"8d59bc8c-9884-4d64-82b5-3819d0c58b8a","Authorize",{"idTag":"volatileocpp"}],
    [2,"dddb2599-d678-4ff8-bf38-a230390a1200","StartTransaction",{"connectorId":"1","idTag":"volatileocpp","meterStart":"42","timestamp":"2017-10-27T19:10:11Z"}],
   [2,"9b25cbb0-c016-41e7-baa0-e796a9565c11","StatusNotification",{"connectorId":"1","errorCode":"NoError","status":"Available"}],
    [2,"29e7a835-6ff6-4cf8-90e6-5d51182f8fdb","StopTransaction",{"idTag":"volatileocpp", "reason":"PowerLoss", "meterStop":"41","timestamp":"2017-10-27T19:10:11Z","transactionId":"1"}],
    [2, "29e7a835-6ff6-4cf8-90e6-5d51182f8fde", "DataTransfer", {"vendorId": "Radboud", "messageId": "No-Idea", "data": "There should be some data here"}],
    [2, "29e7a835-6ff6-4cf8-90e6-5d51182f8fdf", "DiagnosticsStatusNotification", {"status": "Uploading"}],
    [2, "29e7a835-6ff6-4cf8-90e6-5d51182f8bea", "FirmwareStatusNotification", {"status": "DownloadFailed"}],
    [2, "29e7a835-6ff6-4cf8-90e6-5d51182f8beb", "GetCompositeSchedule", {"connectorId": "1", "duration": "1337", "chargingRateUnit": "W"}],
    [2, "29e7a835-6ff6-4cf8-90e6-5d51182f8bec", "GetConfiguration", {"key": ["keykeykey"]}],
   [2, "29e7a835-6ff6-4cf8-90e6-5d51182f8bed", "GetDiagnostics", {"location": "http://example.com/ocpp", "retries": "5", "retryInterval": "30", "startTime": "2012-10-27T19:10:11Z", "stopTime": "2017-10-27T19:10:11Z"}],
   [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2bee", "GetLocalListVersion", {}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2bef", "MeterValues", {"connectorId": 1, "transactionId": "42", "meterValue": [{"timestamp": "2017-10-27T19:10:11Z", "sampledValue": [{"value": "xxx", "context": "Trigger", "format": "SignedData", "measurand": "Power.Active.Export", "phase": "L1", "location":"Cable", "unit": "kWh"}]}]}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2caa", "RemoteStartTransaction", {"connectorId": "1", "idTag": "volatileocpp"}], #chargingProfile parameter skipped
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2cab", "RemoteStopTransaction", {"transactionId": "42"}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2cac", "ReserveNow", {"connectorId": "1", "expiryDate": "2017-10-27T19:10:11Z", "idTag": "volatileocpp", "reservationId": "89"}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2cad", "Reset", {"type": "Hard"}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2cae", "SendLocalList", {"listVersion": "2", "localAuthorizationList": [{"idTag": "volatileocpp", "idTagInfo": {"status":"Accepted"}}], "updateType": "Full"}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2caf", "SetChargingProfile", {"connectorId":"1", "csChargingProfiles": {"chargingProfileId":"888","transactionId":"78", "stackLevel":"1", "chargingProfilePurpose":"TxProfile", "chargingProfileKind": "Absolute", "recurrencyKind":"Weekly", "validFrom":"2017-10-27T19:10:11Z", "validTo":"2017-10-27T19:10:11Z", "chargingSchedule":{"duration":"10", "chargingRateUnit":"W", "chargingSchedulePeriod":[{"startPeriod":"100", "limit": "0.1"}]}}}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2cba", "TriggerMessage", {"requestedMessage": "Heartbeat", "connectorId": "1"}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2cbb", "UnlockConnector", {"connectorId":"1","evseId": "0",}],
    [2, "a187bcd6-4042-4a82-b6d4-b4c55d2f2bee", "UpdateFirmware", {"location": "http://example.com/ocpp", "retries":"5", "retrieveDate":"2017-10-27T19:10:11Z","retryInterval":"30"}],
    ]

responses = [
    [
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "Authorize",
  {
    "customData": {
      "vendorId": "string"
    },
    "idTokenInfo": {
      "customData": {
        "vendorId": "string"
      },
      "status": "Accepted",
      "cacheExpiryDateTime": "2019-08-24T14:15:22Z",
      "chargingPriority": 0,
      "language1": "string",
      "evseId": [
        0
      ],
      "groupIdToken": {
        "customData": {
          "vendorId": "string"
        },
        "additionalInfo": [
          {
            "customData": {
              "vendorId": "string"
            },
            "additionalIdToken": "string",
            "type": "string"
          }
        ],
        "idToken": "string",
        "type": "Central"
      },
      "language2": "string",
      "personalMessage": {
        "customData": {
          "vendorId": "string"
        },
        "format": "ASCII",
        "language": "string",
        "content": "string"
      }
    },
    "certificateStatus": "Accepted"
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "BootNotification",
  {
    "customData": {
      "vendorId": "string"
    },
    "currentTime": "2019-08-24T14:15:22Z",
    "interval": 0,
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "CancelReservation",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "CertificateSigned",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ChangeAvailability",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ClearCache",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ClearChargingProfile",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ClearDisplayMessage",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ClearVariableMonitoring",
  {
    "customData": {
      "vendorId": "string"
    },
    "clearMonitoringResult": [
      {
        "customData": {
          "vendorId": "string"
        },
        "status": "Accepted",
        "id": 0,
        "statusInfo": {
          "customData": {
            "vendorId": "string"
          },
          "reasonCode": "string",
          "additionalInfo": "string"
        }
      }
    ]
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ClearedChargingLimit",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "CostUpdated",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "CustomerInformation",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "DataTransfer",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    },
    "data": ""
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "DeleteCertificate",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "FirmwareStatusNotification",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "Get15118EVCertificate",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    },
    "exiResponse": "string"
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetBaseReport",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetCertificateStatus",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    },
    "ocspResult": "string"
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetChargingProfiles",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetCompositeSchedule",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    },
    "schedule": {
      "customData": {
        "vendorId": "string"
      },
      "chargingSchedulePeriod": [
        {
          "customData": {
            "vendorId": "string"
          },
          "startPeriod": 0,
          "limit": 0,
          "numberPhases": 0,
          "phaseToUse": 0
        }
      ],
      "evseId": 0,
      "duration": 0,
      "scheduleStart": "2019-08-24T14:15:22Z",
      "chargingRateUnit": "W"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetDisplayMessages",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetInstalledCertificateIds",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    },
    "certificateHashDataChain": [
      {
        "customData": {
          "vendorId": "string"
        },
        "certificateHashData": {
          "customData": {
            "vendorId": "string"
          },
          "hashAlgorithm": "SHA256",
          "issuerNameHash": "string",
          "issuerKeyHash": "string",
          "serialNumber": "string"
        },
        "certificateType": "V2GRootCertificate",
        "childCertificateHashData": [
          {
            "customData": {
              "vendorId": "string"
            },
            "hashAlgorithm": "SHA256",
            "issuerNameHash": "string",
            "issuerKeyHash": "string",
            "serialNumber": "string"
          }
        ]
      }
    ]
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetLocalListVersion",
  {
    "customData": {
      "vendorId": "string"
    },
    "versionNumber": 0
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetLog",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    },
    "filename": "string"
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetMonitoringReport",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetReport",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetTransactionStatus",
  {
    "customData": {
      "vendorId": "string"
    },
    "ongoingIndicator": True,
    "messagesInQueue": True
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "GetVariables",
  {
    "customData": {
      "vendorId": "string"
    },
    "getVariableResult": [
      {
        "customData": {
          "vendorId": "string"
        },
        "attributeStatusInfo": {
          "customData": {
            "vendorId": "string"
          },
          "reasonCode": "string",
          "additionalInfo": "string"
        },
        "attributeStatus": "Accepted",
        "attributeType": "Actual",
        "attributeValue": "string",
        "component": {
          "customData": {
            "vendorId": "string"
          },
          "evse": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "connectorId": 0
          },
          "name": "string",
          "instance": "string"
        },
        "variable": {
          "customData": {
            "vendorId": "string"
          },
          "name": "string",
          "instance": "string"
        }
      }
    ]
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "Heartbeat",
  {
    "customData": {
      "vendorId": "string"
    },
    "currentTime": "2019-08-24T14:15:22Z"
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "InstallCertificate",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "LogStatusNotification",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "MeterValues",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyChargingLimit",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyCustomerInformation",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyDisplayMessages",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyEVChargingNeeds",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyEVChargingSchedule",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyEvent",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyMonitoringReport",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "NotifyReport",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "PublishFirmware",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "PublishFirmwareStatusNotification",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ReportChargingProfiles",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "StartTransaction",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    },
    "transactionId": "string"
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "StopTransaction",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ReservationStatusUpdate",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "ReserveNow",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "Reset",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SecurityEventNotification",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SendLocalList",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetChargingProfile",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetDisplayMessage",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetMonitoringBase",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetMonitoringLevel",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetNetworkProfile",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetVariableMonitoring",
  {
    "customData": {
      "vendorId": "string"
    },
    "setMonitoringResult": [
      {
        "customData": {
          "vendorId": "string"
        },
        "id": 0,
        "statusInfo": {
          "customData": {
            "vendorId": "string"
          },
          "reasonCode": "string",
          "additionalInfo": "string"
        },
        "status": "Accepted",
        "type": "UpperThreshold",
        "component": {
          "customData": {
            "vendorId": "string"
          },
          "evse": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "connectorId": 0
          },
          "name": "string",
          "instance": "string"
        },
        "variable": {
          "customData": {
            "vendorId": "string"
          },
          "name": "string",
          "instance": "string"
        },
        "severity": 0
      }
    ]
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SetVariables",
  {
    "customData": {
      "vendorId": "string"
    },
    "setVariableResult": [
      {
        "customData": {
          "vendorId": "string"
        },
        "attributeType": "Actual",
        "attributeStatus": "Accepted",
        "attributeStatusInfo": {
          "customData": {
            "vendorId": "string"
          },
          "reasonCode": "string",
          "additionalInfo": "string"
        },
        "component": {
          "customData": {
            "vendorId": "string"
          },
          "evse": {
            "customData": {
              "vendorId": "string"
            },
            "id": 0,
            "connectorId": 0
          },
          "name": "string",
          "instance": "string"
        },
        "variable": {
          "customData": {
            "vendorId": "string"
          },
          "name": "string",
          "instance": "string"
        }
      }
    ]
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "SignCertificate",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "StatusNotification",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "TransactionEvent",
  {
    "customData": {
      "vendorId": "string"
    },
    "totalCost": 0,
    "chargingPriority": 0,
    "idTokenInfo": {
      "customData": {
        "vendorId": "string"
      },
      "status": "Accepted",
      "cacheExpiryDateTime": "2019-08-24T14:15:22Z",
      "chargingPriority": 0,
      "language1": "string",
      "evseId": [
        0
      ],
      "groupIdToken": {
        "customData": {
          "vendorId": "string"
        },
        "additionalInfo": [
          {
            "customData": {
              "vendorId": "string"
            },
            "additionalIdToken": "string",
            "type": "string"
          }
        ],
        "idToken": "string",
        "type": "Central"
      },
      "language2": "string",
      "personalMessage": {
        "customData": {
          "vendorId": "string"
        },
        "format": "ASCII",
        "language": "string",
        "content": "string"
      }
    },
    "updatedPersonalMessage": {
      "customData": {
        "vendorId": "string"
      },
      "format": "ASCII",
      "language": "string",
      "content": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "TriggerMessage",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "UnlockConnector",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Unlocked",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "UnpublishFirmware",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "DownloadOngoing"
  }
],
[
  3,
  "811D0937-A437-477D-BBA8-45EA8D4DF84D",
  "UpdateFirmware",
  {
    "customData": {
      "vendorId": "string"
    },
    "status": "Accepted",
    "statusInfo": {
      "customData": {
        "vendorId": "string"
      },
      "reasonCode": "string",
      "additionalInfo": "string"
    }
  }
]
]