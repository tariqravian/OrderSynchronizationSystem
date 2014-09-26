﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IST.OrderSynchronizationSystem {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SqlResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IST.OrderSynchronizationSystem.SqlResource", typeof(SqlResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete from [Logs]
        ///.
        /// </summary>
        internal static string source_ClearLogs {
            get {
                return ResourceManager.GetString("source_ClearLogs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select top 1 LastSynchOrderId
        ///        from OssLastSyncOrderDetail
        ///    .
        /// </summary>
        internal static string source_GetOssLastSyncOrderId {
            get {
                return ResourceManager.GetString("source_GetOssLastSyncOrderId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [LogId]      
        ///      ,[OrderId]
        ///      ,[LogText]
        ///      ,[CreatedOn]
        ///  FROM [dbo].[Logs]
        ///  order by CreatedOn desc
        ///.
        /// </summary>
        internal static string source_LoadLogs {
            get {
                return ResourceManager.GetString("source_LoadLogs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [OSSShipmentMappingsId]
        ///      ,[SourceShipmentMethod]
        ///      ,[DestinationShipmentMethod]      
        ///  FROM [dbo].[OSSShipmentMappings]
        ///.
        /// </summary>
        internal static string source_LoadShipmentMapping {
            get {
                return ResourceManager.GetString("source_LoadShipmentMapping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete from OssLastSyncOrderDetail
        ///      insert into OssLastSyncOrderDetail ([LastSynchOrderId]) values (@LastValuesReturn)
        ///    .
        /// </summary>
        internal static string source_SetOssLastSyncOrderId {
            get {
                return ResourceManager.GetString("source_SetOssLastSyncOrderId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [dbo].[Logs]
        ///  ([LogTypeId]
        ///  ,[OrderId]
        ///  ,[LogText]
        ///  ,[CreatedOn])
        ///  VALUES
        ///  (@LogTypeId,
        ///  @OrderId,
        ///  @LogText,
        ///  @CreatedOn
        ///  ).
        /// </summary>
        internal static string source_sql_Insert_Log {
            get {
                return ResourceManager.GetString("source_sql_Insert_Log", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select oi.ItemCode As SKU,
        ///       oi.ItemDescription As &apos;Description&apos;,
        ///	   Cast(oi.Quantity As int) As Quantity,
        ///	   oi.CustomValue1 As Custom1,
        ///	   oi.CustomValue2 As Custom2,
        ///	   oi.CustomValue3 As Custom3,
        ///	   oi.CustomValue4 As Custom4,
        ///	   oi.CustomValue5 As Custom5,
        ///	   &apos;&apos; As Custom6
        ///From   OrderItems as oi With(NoLock)
        ///Where  oi.OrderId = @THubOrderId.
        /// </summary>
        internal static string source_sql_PullOrderItems {
            get {
                return ResourceManager.GetString("source_sql_PullOrderItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///      Select  --Top 1 
        ///		ord.OrderId As THubOrderID,
        ///       ord.ChannelOrderReference As OrderID, 
        ///       ord.OrderDate As Orderdate, 
        ///       Case ord.ShippingAddrSameAsBilling
        ///	    When 0
        ///		 Then ord.SAddr_Company
        ///		When 1
        ///		 Then ord.BAddr_Company
        ///	   End As Company,
        ///       ord.SAddr_FirstName As FirstName,
        ///       ord.SAddr_LastName As LastName,
        ///       Case ord.ShippingAddrSameAsBilling
        ///	    When 0
        ///	     Then ord.SAddr_Line1
        ///		When 1
        ///		 Then ord.BAddr_Line1
        ///	   End As Address1,
        ///        [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string source_sql_PullOrdersFromThub {
            get {
                return ResourceManager.GetString("source_sql_PullOrdersFromThub", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///      Select  --Top 1 
        ///		ord.OrderId As THubOrderID,
        ///       ord.ChannelOrderReference As OrderID, 
        ///       ord.OrderDate As Orderdate, 
        ///       Case ord.ShippingAddrSameAsBilling
        ///	    When 0
        ///		 Then ord.SAddr_Company
        ///		When 1
        ///		 Then ord.BAddr_Company
        ///	   End As Company,
        ///       ord.SAddr_FirstName As FirstName,
        ///       ord.SAddr_LastName As LastName,
        ///       Case ord.ShippingAddrSameAsBilling
        ///	    When 0
        ///	     Then ord.SAddr_Line1
        ///		When 1
        ///		 Then ord.BAddr_Line1
        ///	   End As Address1,
        ///        [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string source_sql_PullOrdersFromThub_ForReaload {
            get {
                return ResourceManager.GetString("source_sql_PullOrdersFromThub_ForReaload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [dbo].[OSSOrders]
        ///      SET [LastSyncWithMBOn] = @DateTimeNow,
        ///	    [OrderStatus] = @OrderStatus
        ///      WHERE [THubOrderId] = @THubOrderId
        ///  .
        /// </summary>
        internal static string source_sql_UpdateOrderCompleted {
            get {
                return ResourceManager.GetString("source_sql_UpdateOrderCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [dbo].[OSSOrders]
        ///      SET [LastSyncWithMBOn] = @DateTimeNow
        ///      WHERE [THubOrderId] = @THubOrderId
        ///  .
        /// </summary>
        internal static string source_sql_UpdateOrderSyncStatus {
            get {
                return ResourceManager.GetString("source_sql_UpdateOrderSyncStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update OSSOrders
        ///set [THubCompleteOrder] = @CompleteOrder, [OrderStatus] = @OrderStatus
        ///where THubOrderReferenceNo = @OssOrderId .
        /// </summary>
        internal static string source_sql_UpdateOssOrder {
            get {
                return ResourceManager.GetString("source_sql_UpdateOssOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select count(*) from Orders With(NoLock).
        /// </summary>
        internal static string source_sql_verify {
            get {
                return ResourceManager.GetString("source_sql_verify", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [dbo].[OSSShipmentMappings]
        ///        SET [SourceShipmentMethod] = @SourceMethod
        ///        ,[DestinationShipmentMethod] = @DestinationMethod      
        ///      WHERE [OSSShipmentMappingsId] = @MappingID
        ///    .
        /// </summary>
        internal static string source_UpdateMappingSql {
            get {
                return ResourceManager.GetString("source_UpdateMappingSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select DestinationShipmentMethod from OSSShipmentMappings where SourceShipmentMethod = @SourceShipment and THubToMBMap = @THubToMbFlag.
        /// </summary>
        internal static string staging_get_Shipment_Mapping_ThubToMoldingBox {
            get {
                return ResourceManager.GetString("staging_get_Shipment_Mapping_ThubToMoldingBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to USPCreateOSSOrders.
        /// </summary>
        internal static string staging_sql_CreateOssOrders {
            get {
                return ResourceManager.GetString("staging_sql_CreateOssOrders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///      INSERT INTO [dbo].[ShipmentTracking]
        ///           ([ORDER_KEY]
        ///           ,[REF_NUMBER_WEB]
        ///           ,[LeadTrackingNumber]
        ///           ,[ShipDate]
        ///           ,[ServiceType])
        ///     VALUES
        ///           (@OrderKey
        ///           ,@RefNumberWeb
        ///           ,@TrackingNumber
        ///           ,@ShipmentDate
        ///           ,@ServiceType)
        ///    .
        /// </summary>
        internal static string staging_sql_InsertShipmentTrackingDetails {
            get {
                return ResourceManager.GetString("staging_sql_InsertShipmentTrackingDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [OSSShipmentMappings]
        ///           ([SourceShipmentMethod]
        ///           ,[DestinationShipmentMethod]
        ///           ,[THubToMBMap])
        ///     VALUES
        ///           (@SourceShipMethod,
        ///           @DestinationShipMethod,
        ///           @THubToMBMap)
        ///    .
        /// </summary>
        internal static string staging_sql_InsertTHubToMbMapping {
            get {
                return ResourceManager.GetString("staging_sql_InsertTHubToMbMapping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select Cast(oc.ConfigValue As bigint) As LastExecutedTHubOrderId From OSSConfigurations As oc Where oc.ConfigKey = &apos;LastUpdatedTHubOrderId&apos;.
        /// </summary>
        internal static string staging_sql_LastExecutedTHubOrderId {
            get {
                return ResourceManager.GetString("staging_sql_LastExecutedTHubOrderId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select count(*) from OSSOrders With(NoLock).
        /// </summary>
        internal static string staging_sql_verify {
            get {
                return ResourceManager.GetString("staging_sql_verify", resourceCulture);
            }
        }
    }
}
