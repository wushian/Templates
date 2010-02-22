﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.1413, CSLA Framework: v3.8.2.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Order.cs'.
//
//     Template: SwitchableObject.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;
using Csla.Validation;

#endregion

namespace PetShop.Tests.ObjF.ParameterizedSQL
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.OrderFactoryName)]
    public partial class Order : BusinessBase< Order >
    {
        #region Contructor(s)

        private Order()
        { /* Require use of factory methods */ }

        internal Order(System.Int32 orderId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_orderIdProperty, orderId);
            }
        }
        #endregion

        #region Validation Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            ValidationRules.AddRule(CommonRules.StringRequired, _userIdProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_userIdProperty, 20));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipAddr1Property);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipAddr1Property, 80));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipAddr2Property, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipCityProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipCityProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipStateProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipStateProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipZipProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipZipProperty, 20));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipCountryProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipCountryProperty, 20));
            ValidationRules.AddRule(CommonRules.StringRequired, _billAddr1Property);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billAddr1Property, 80));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billAddr2Property, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _billCityProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billCityProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _billStateProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billStateProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _billZipProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billZipProperty, 20));
            ValidationRules.AddRule(CommonRules.StringRequired, _billCountryProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billCountryProperty, 20));
            ValidationRules.AddRule(CommonRules.StringRequired, _courierProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_courierProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _billToFirstNameProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billToFirstNameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _billToLastNameProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_billToLastNameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipToFirstNameProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipToFirstNameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _shipToLastNameProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_shipToLastNameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _localeProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_localeProperty, 20));
        }

        #endregion

        #region Properties

        /// <summary>
        /// Used for optimistic concurrency.
        /// </summary>
        [NotUndoable]
        internal System.Byte[] Timestamp = new System.Byte[8];

        private static readonly PropertyInfo< System.Int32 > _orderIdProperty = RegisterProperty< System.Int32 >(p => p.OrderId);
		[System.ComponentModel.DataObjectField(true, true)]
        public System.Int32 OrderId
        {
            get { return GetProperty(_orderIdProperty); }
            internal set{ SetProperty(_orderIdProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _userIdProperty = RegisterProperty< System.String >(p => p.UserId);
        public System.String UserId
        {
            get { return GetProperty(_userIdProperty); }
            set{ SetProperty(_userIdProperty, value); }
        }

        private static readonly PropertyInfo< System.DateTime > _orderDateProperty = RegisterProperty< System.DateTime >(p => p.OrderDate);
        public System.DateTime OrderDate
        {
            get { return GetProperty(_orderDateProperty); }
            set{ SetProperty(_orderDateProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _shipAddr1Property = RegisterProperty< System.String >(p => p.ShipAddr1);
        public System.String ShipAddr1
        {
            get { return GetProperty(_shipAddr1Property); }
            set{ SetProperty(_shipAddr1Property, value); }
        }

        private static readonly PropertyInfo< System.String > _shipAddr2Property = RegisterProperty< System.String >(p => p.ShipAddr2);
        public System.String ShipAddr2
        {
            get { return GetProperty(_shipAddr2Property); }
            set{ SetProperty(_shipAddr2Property, value); }
        }

        private static readonly PropertyInfo< System.String > _shipCityProperty = RegisterProperty< System.String >(p => p.ShipCity);
        public System.String ShipCity
        {
            get { return GetProperty(_shipCityProperty); }
            set{ SetProperty(_shipCityProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _shipStateProperty = RegisterProperty< System.String >(p => p.ShipState);
        public System.String ShipState
        {
            get { return GetProperty(_shipStateProperty); }
            set{ SetProperty(_shipStateProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _shipZipProperty = RegisterProperty< System.String >(p => p.ShipZip);
        public System.String ShipZip
        {
            get { return GetProperty(_shipZipProperty); }
            set{ SetProperty(_shipZipProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _shipCountryProperty = RegisterProperty< System.String >(p => p.ShipCountry);
        public System.String ShipCountry
        {
            get { return GetProperty(_shipCountryProperty); }
            set{ SetProperty(_shipCountryProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _billAddr1Property = RegisterProperty< System.String >(p => p.BillAddr1);
        public System.String BillAddr1
        {
            get { return GetProperty(_billAddr1Property); }
            set{ SetProperty(_billAddr1Property, value); }
        }

        private static readonly PropertyInfo< System.String > _billAddr2Property = RegisterProperty< System.String >(p => p.BillAddr2);
        public System.String BillAddr2
        {
            get { return GetProperty(_billAddr2Property); }
            set{ SetProperty(_billAddr2Property, value); }
        }

        private static readonly PropertyInfo< System.String > _billCityProperty = RegisterProperty< System.String >(p => p.BillCity);
        public System.String BillCity
        {
            get { return GetProperty(_billCityProperty); }
            set{ SetProperty(_billCityProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _billStateProperty = RegisterProperty< System.String >(p => p.BillState);
        public System.String BillState
        {
            get { return GetProperty(_billStateProperty); }
            set{ SetProperty(_billStateProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _billZipProperty = RegisterProperty< System.String >(p => p.BillZip);
        public System.String BillZip
        {
            get { return GetProperty(_billZipProperty); }
            set{ SetProperty(_billZipProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _billCountryProperty = RegisterProperty< System.String >(p => p.BillCountry);
        public System.String BillCountry
        {
            get { return GetProperty(_billCountryProperty); }
            set{ SetProperty(_billCountryProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _courierProperty = RegisterProperty< System.String >(p => p.Courier);
        public System.String Courier
        {
            get { return GetProperty(_courierProperty); }
            set{ SetProperty(_courierProperty, value); }
        }

        private static readonly PropertyInfo< System.Decimal > _totalPriceProperty = RegisterProperty< System.Decimal >(p => p.TotalPrice);
        public System.Decimal TotalPrice
        {
            get { return GetProperty(_totalPriceProperty); }
            set{ SetProperty(_totalPriceProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _billToFirstNameProperty = RegisterProperty< System.String >(p => p.BillToFirstName);
        public System.String BillToFirstName
        {
            get { return GetProperty(_billToFirstNameProperty); }
            set{ SetProperty(_billToFirstNameProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _billToLastNameProperty = RegisterProperty< System.String >(p => p.BillToLastName);
        public System.String BillToLastName
        {
            get { return GetProperty(_billToLastNameProperty); }
            set{ SetProperty(_billToLastNameProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _shipToFirstNameProperty = RegisterProperty< System.String >(p => p.ShipToFirstName);
        public System.String ShipToFirstName
        {
            get { return GetProperty(_shipToFirstNameProperty); }
            set{ SetProperty(_shipToFirstNameProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _shipToLastNameProperty = RegisterProperty< System.String >(p => p.ShipToLastName);
        public System.String ShipToLastName
        {
            get { return GetProperty(_shipToLastNameProperty); }
            set{ SetProperty(_shipToLastNameProperty, value); }
        }

        private static readonly PropertyInfo< System.Int32 > _authorizationNumberProperty = RegisterProperty< System.Int32 >(p => p.AuthorizationNumber);
        public System.Int32 AuthorizationNumber
        {
            get { return GetProperty(_authorizationNumberProperty); }
            set{ SetProperty(_authorizationNumberProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _localeProperty = RegisterProperty< System.String >(p => p.Locale);
        public System.String Locale
        {
            get { return GetProperty(_localeProperty); }
            set{ SetProperty(_localeProperty, value); }
        }



        //AssociatedOneToMany
        private static readonly PropertyInfo< LineItemList > _lineItemsProperty = RegisterProperty<LineItemList>(p => p.LineItems, Csla.RelationshipTypes.Child);
        public LineItemList LineItems
        {
            get
            {
                if(!FieldManager.FieldExists(_lineItemsProperty))
                {
                    if(IsNew || !PetShop.Tests.ObjF.ParameterizedSQL.LineItemList.Exists(new PetShop.Tests.ObjF.ParameterizedSQL.LineItemCriteria {OrderId = OrderId}))
                        LoadProperty(_lineItemsProperty, PetShop.Tests.ObjF.ParameterizedSQL.LineItemList.NewList());
                    else
                        LoadProperty(_lineItemsProperty, PetShop.Tests.ObjF.ParameterizedSQL.LineItemList.GetByOrderId(OrderId));
                }

                return GetProperty(_lineItemsProperty);
            }
        }


        //AssociatedOneToMany
        private static readonly PropertyInfo< OrderStatusList > _orderStatusesProperty = RegisterProperty<OrderStatusList>(p => p.OrderStatuses, Csla.RelationshipTypes.Child);
        public OrderStatusList OrderStatuses
        {
            get
            {
                if(!FieldManager.FieldExists(_orderStatusesProperty))
                {
                    if(IsNew || !PetShop.Tests.ObjF.ParameterizedSQL.OrderStatusList.Exists(new PetShop.Tests.ObjF.ParameterizedSQL.OrderStatusCriteria {OrderId = OrderId}))
                        LoadProperty(_orderStatusesProperty, PetShop.Tests.ObjF.ParameterizedSQL.OrderStatusList.NewList());
                    else
                        LoadProperty(_orderStatusesProperty, PetShop.Tests.ObjF.ParameterizedSQL.OrderStatusList.GetByOrderId(OrderId));
                }

                return GetProperty(_orderStatusesProperty);
            }
        }

        #endregion

        #region Root Factory Methods 
        
        public static Order NewOrder()
        {
            return DataPortal.Create< Order >();
        }

        public static Order GetByOrderId(System.Int32 orderId)
        {
            return DataPortal.Fetch< Order >(
                new OrderCriteria {OrderId = orderId});
        }

        public static void DeleteOrder(System.Int32 orderId)
        {
                DataPortal.Delete(new OrderCriteria (orderId));
        }
        
        #endregion

        #region Child Factory Methods 
        
        internal static Order NewOrderChild()
        {
            return DataPortal.CreateChild< Order >();
        }
        internal static Order GetByOrderIdChild(System.Int32 orderId)
        {
            return DataPortal.FetchChild< Order >(
                new OrderCriteria {OrderId = orderId});
        }

        #endregion

        #region Exists Command

        public static bool Exists(OrderCriteria criteria)
        {
            return ExistsCommand.Execute(criteria);
        }

        #endregion

        #region Overridden properties

        /// <summary>
        /// Returns true if the business object or any of its children properties are dirty.
        /// </summary>
        public override bool IsDirty
        {
            get
            {
                if (base.IsDirty) return true;
                if (FieldManager.FieldExists(_lineItemsProperty) && LineItems.IsDirty) return true;
                if (FieldManager.FieldExists(_orderStatusesProperty) && OrderStatuses.IsDirty) return true;

                return false;
            }
        }

        #endregion


    }
}