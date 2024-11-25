// Copyright (c) Microsoft Corporation. All rights reserved.
    // Licensed under the MIT License.
      // <auto-generated />

      using System;using System.Text.Json;using System.Text.Json.Serialization;using System.Net;using System.Threading.Tasks;using Microsoft.AspNetCore.Mvc;using PetStore.Service.Models;

      namespace PetStore.Service {

      public interface IPetInsurance {
      ///<summary>
/// Gets the singleton resource.
///</summary>
Task<Insurance> GetAsync( int petId);
///<summary>
/// Updates the singleton resource.
///</summary>
Task<Insurance> UpdateAsync( int petId, InsuranceUpdate properties);

    }
   } 
