#!/usr/bin/env python2

messages = [
    [
  2,
  "89950B79-542D-4799-A97E-54364D65D04E",
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
  "C435F6D6-3193-46FB-95F8-6F377573A91E",
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
  "5F8716AA-587E-4BCA-BE79-36311A0442C3",
  "ClearCache",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  2,
  "B58FE03A-60C1-4A98-83AD-8E520C8070BC",
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
  "35AED449-B025-47C6-9121-342DDBC9BA4F",
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
  "F11A0CBE-51A2-4032-BE7E-980C18EDB761",
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
  "364ECA1A-3F8B-4AF5-BF8F-7EFAD897BF47",
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
  "152083EB-9099-47B9-8992-20CB310AF671",
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
  "36C86908-3871-4BCD-A6CE-A8876FFC157A",
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
  "EBCD3B04-F2D7-46E7-A51E-164FD67E96E2",
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
  "3C8ABB4D-B72C-4FF5-ADF6-F5195C1082B6",
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
  "F28670F3-D787-4FAE-99A6-2E7AB6C26CB0",
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
  "9C716D54-4ED1-4EE6-8396-A014BC4CA091",
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
  "55D3C3ED-B5F8-48E1-8C7A-AE625833845B",
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
  "57CE9FD6-CA46-447E-B0B7-09B5965B8775",
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
  "D2086710-00FC-434B-BAF0-302DEF58B44A",
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
  "6D9B343B-5FAB-47C6-AEEB-6E0BADDFD0E1",
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
  "EF3CCBE7-0C28-47B9-ADFD-4B5303F304EB",
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
  "292A2D36-673C-41EB-BB4A-CD0B33CC4711",
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
  "0387F89A-97C2-4FB0-B499-1666EF156F98",
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
  "6F85C496-4898-4F1E-9A11-88E6911553CA",
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
  "B0F417E7-4498-4AA5-9373-7E9B131308F0",
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
  "1BBE34BE-5A0D-42A4-88A7-09954F66FE2D",
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
  "636E0887-CFD7-4B42-ACBC-A2F474E17D47",
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
  "726FAECE-7872-4A62-9A74-20C7C2C3FDE4",
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
  "B9C09BA9-76FD-4DA9-AB65-D4DAEA60E940",
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
  "7820FCA3-08D0-4EF8-B2D1-5BAEAF7222A7",
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
  "16FB4CE1-13FB-46C2-A1C5-5959E7EAD1A4",
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
  "587ABC41-CA8A-41CC-AB5D-A23F00C89FE0",
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
  "AE6BBAA3-B1C3-4187-A4D9-BA766825B4F7",
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
  "7706B225-8547-43DB-B976-F9C0563FE933",
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
  "9D77F4BE-E9C5-457E-906E-3912DE8CCD36",
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
  "FFCEE513-8AD4-4098-993B-F3958B8D1F97",
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
  "C3AE10C0-DF73-4976-AB0B-91769EAD9A6C",
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
  "BEF5FE2F-F6F6-44C9-87EB-5D784A7289F9",
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
  "68CD5B0F-0401-4434-90DA-961DAD1CB162",
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
  "DF53AB92-CCCD-48D6-9DE1-8658F0B1353B",
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
  "30353376-26DA-4AFE-B4A3-0191E30C8C40",
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
  "B2B19582-7662-4114-AFEC-3554C7374CE3",
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
  "A3374553-B817-4869-8729-84229A199B8B",
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
  "89865CB1-77D1-482E-851B-F8411B269AF7",
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
  "C83FF3A2-3199-4225-9433-BF02925BF21E",
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
  "CEC9D2D4-39B5-44C1-ADDE-B712B8C84736",
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
  "52BCDF92-D01D-4E77-BDA5-9DEF698C438D",
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
  "493170B6-9519-4C62-A52D-04A964411CB7",
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
  "C0286DD2-3D45-4C97-BC7C-3BB90D047A97",
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
  "BC018D6D-21C2-453B-B5D5-0DB7318ADAA7",
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
  "3DFE6444-91CF-4D3D-A637-E735F421147E",
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
  "23753487-26B8-4071-8069-02632273A415",
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
  "75719239-B87F-4056-A851-89D92393734B",
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
  "51DABAA4-1978-4CF4-BACF-796F08CF1C5F",
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
  "473E4851-7509-46F6-994E-5D36E1B704A9",
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
  "8A6431BB-D84D-40C7-B626-C47B2A271720",
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
  "C6ABE535-6381-4DC4-8245-FD713013FF2E",
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
  "147AA064-1E0C-4B6B-B6DA-3AF153DF5B3B",
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
  "6679AA22-5B15-4B17-B7C6-FF292DBE9A9E",
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
  "EA350A1A-E0EC-49D8-9A98-3D5433FC3119",
  "ClearedChargingLimit",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "158617C1-1156-47DC-91F8-A116DE0F5365",
  "CostUpdated",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "C4CBCF8F-8A22-4115-B201-42548B78E815",
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
  "5DA7F543-E254-4939-8E06-DC191F2B77B9",
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
  "0E510432-7933-447C-B1CD-F4163D1D16E2",
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
  "41F70682-8747-4D36-B8BA-613590666F5E",
  "FirmwareStatusNotification",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "FCE4D6BB-5AFC-4DA6-B9D1-E161C7DB6667",
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
  "5E9636D8-E180-4EB6-82AD-CA6FDB01C432",
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
  "15D7B6D5-1F26-4D2A-8052-B628E7A7DCCD",
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
  "257B001E-F4BE-43E7-8335-93D1FA2133FB",
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
  "53504B96-9221-48EE-8C9D-171854EF1D79",
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
  "9BF88ED7-064E-48F5-83CA-A7A69B565CEA",
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
  "75033A2B-02AE-4827-96BB-8E894A2691B8",
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
  "F9BAC950-C2D0-443C-930B-3B27A892405D",
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
  "0E4360DA-954D-45DF-91E2-9C4E01959EA8",
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
  "A4F61D9B-BE17-4A71-8604-5EE3F6B4EDA6",
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
  "F07136AA-6A4A-484A-819B-E8EFE4327B69",
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
  "FF15C284-D7AD-42DD-8729-FBC286EBC753",
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
  "CA694CD8-A738-47E2-ACFF-4B97F54AD293",
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
  "A132075A-BE07-40CA-B57D-CA98FEE1C135",
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
  "2F3A24BA-18F6-4813-BCB2-9286D4AE5E7A",
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
  "1492323A-D895-46DD-A736-7412685A75C2",
  "LogStatusNotification",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "9D580383-5B63-456C-B610-1FE0399CE13F",
  "MeterValues",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "A8ABCD90-6BA3-40C3-A8C2-2F99D220E11A",
  "NotifyChargingLimit",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "027BDAED-0780-49F0-8F3D-EAFEDD0C73EB",
  "NotifyCustomerInformation",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "A039DB6B-6068-4C44-B797-0A41E80D4691",
  "NotifyDisplayMessages",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "30C383EC-53A5-43FD-A0B4-2FE261B75376",
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
  "61677E37-F36B-4480-9522-99287D73FDAA",
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
  "7FBA730F-6D22-4B79-86D4-EAFE368E1C1A",
  "NotifyEvent",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "61E4E2C4-EE89-478B-8276-30100A18FF0E",
  "NotifyMonitoringReport",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "2CA7DCC2-9769-481D-A82B-EF19A3AF2832",
  "NotifyReport",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "A4D045B8-C444-452F-9125-24E0A61C0AEA",
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
  "712170BC-3C39-45DC-A380-4D9CB1641F8D",
  "PublishFirmwareStatusNotification",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "0F7B0835-69D9-4F35-8F02-D79E398FC807",
  "ReportChargingProfiles",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "27C2B91B-1309-42C7-864E-94E3AC991B49",
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
  "278641B9-CA3B-4AA1-A370-BA7E8BE56537",
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
  "6E899C17-D57D-41E3-A891-03758829419C",
  "ReservationStatusUpdate",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "8F75A49E-6191-411B-992B-72D7F7FF2050",
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
  "AE3D1224-14DB-4A8C-9CC6-B7D9F2595F4F",
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
  "B2392D4C-C428-46CF-846D-4E83ABD4F454",
  "SecurityEventNotification",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "F7699813-B95C-4BDF-B4D2-F92EB539AFB9",
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
  "EE61AC4B-ED29-40BD-9FC5-BCA8D5922803",
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
  "F43BEAE9-16E8-40CC-A599-4DDC96A71EC4",
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
  "989183B5-2BD1-4DDA-A0EE-0D9E88CF171D",
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
  "F96778FC-B376-4434-865D-0E8A11B22321",
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
  "4C67C79C-0F6F-4F35-92D1-CA241383232A",
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
  "F23E087D-E64A-4DC7-B97C-22E5B7EF9FA9",
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
  "C1112903-999D-4630-9DA5-27968735D609",
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
  "48EFEF43-B3E5-40E8-BE1A-57844B860CAC",
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
  "791C2F89-EA31-4691-AED7-51F8219381B2",
  "StatusNotification",
  {
    "customData": {
      "vendorId": "string"
    }
  }
],
[
  3,
  "EAA86885-26AF-41F5-B90C-BEF37C7E1547",
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
  "9ECE813E-5466-4075-B1B0-12F8AD81590D",
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
  "06A1379B-4C69-4F8D-99D4-72FADB4043C2",
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
  "2F245CE8-2CC5-452E-947A-74429848F790",
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
  "CD8A83B0-635C-4B82-ADF5-7E70EEE88A30",
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