//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CopaceticSoftware.pMixins.CodeGenerator v0.6.0.457
//      for file genesis_dotnet\Genesis.NET\Entities\Responses\Successful\WpfCreateSuccessResponse.cs.
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.  
// </auto-generated> 
//------------------------------------------------------------------------------
namespace Genesis.Net.Entities.Responses.Successful
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public partial class WpfCreateSuccessResponse : pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionModel.ITransactionModelRequirements, pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.AsyncTransactionModel.IAsyncTransactionModelRequirements, pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionStatusModel.ITransactionStatusModelRequirements, pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.MoneyModel.IMoneyModelRequirements, pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.ErrorModel.IErrorModelRequirements, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.TransactionModel>, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.AsyncTransactionModel>, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.TransactionStatusModel>, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.MoneyModel>, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.ErrorModel>
	{
		private sealed class __Mixins
		{
			public static global::System.Object ____Lock = new global::System.Object ();
			public __pMixinAutoGenerated.Genesis_Net_Entities_Responses_TransactionModel.TransactionModelMasterWrapper Genesis_Net_Entities_Responses_TransactionModel;
			public __pMixinAutoGenerated.Genesis_Net_Entities_Responses_AsyncTransactionModel.AsyncTransactionModelMasterWrapper Genesis_Net_Entities_Responses_AsyncTransactionModel;
			public __pMixinAutoGenerated.Genesis_Net_Entities_Responses_TransactionStatusModel.TransactionStatusModelMasterWrapper Genesis_Net_Entities_Responses_TransactionStatusModel;
			public __pMixinAutoGenerated.Genesis_Net_Entities_Responses_MoneyModel.MoneyModelMasterWrapper Genesis_Net_Entities_Responses_MoneyModel;
			public __pMixinAutoGenerated.Genesis_Net_Entities_Responses_ErrorModel.ErrorModelMasterWrapper Genesis_Net_Entities_Responses_ErrorModel;
			public __Mixins (WpfCreateSuccessResponse target)
			{
				Genesis_Net_Entities_Responses_TransactionModel = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.Genesis_Net_Entities_Responses_TransactionModel.TransactionModelMasterWrapper> ((pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionModel.ITransactionModelRequirements)target);
				Genesis_Net_Entities_Responses_AsyncTransactionModel = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.Genesis_Net_Entities_Responses_AsyncTransactionModel.AsyncTransactionModelMasterWrapper> ((pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.AsyncTransactionModel.IAsyncTransactionModelRequirements)target);
				Genesis_Net_Entities_Responses_TransactionStatusModel = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.Genesis_Net_Entities_Responses_TransactionStatusModel.TransactionStatusModelMasterWrapper> ((pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionStatusModel.ITransactionStatusModelRequirements)target);
				Genesis_Net_Entities_Responses_MoneyModel = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.Genesis_Net_Entities_Responses_MoneyModel.MoneyModelMasterWrapper> ((pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.MoneyModel.IMoneyModelRequirements)target);
				Genesis_Net_Entities_Responses_ErrorModel = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.Genesis_Net_Entities_Responses_ErrorModel.ErrorModelMasterWrapper> ((pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.ErrorModel.IErrorModelRequirements)target);
			}
			[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
			[global::System.Diagnostics.DebuggerStepThrough]
			public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse target)
			{
				Genesis_Net_Entities_Responses_TransactionModel.__ActivateMixinDependencies (target);
				Genesis_Net_Entities_Responses_AsyncTransactionModel.__ActivateMixinDependencies (target);
				Genesis_Net_Entities_Responses_TransactionStatusModel.__ActivateMixinDependencies (target);
				Genesis_Net_Entities_Responses_MoneyModel.__ActivateMixinDependencies (target);
				Genesis_Net_Entities_Responses_ErrorModel.__ActivateMixinDependencies (target);
			}
		}
		private sealed class __pMixinAutoGenerated
		{
			public sealed class Genesis_Net_Entities_Responses_TransactionModel
			{
				public class TransactionModelMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public TransactionModelMasterWrapper (pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionModel.ITransactionModelRequirements target)
					{
						_mixinInstance = base.TryActivateMixin<pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionModel.TransactionModelAbstractWrapper> (target);
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::Genesis.Net.Entities.Responses.TransactionModel _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String UniqueId {
						get {
							return base.ExecutePropertyGet ("UniqueId", () => _mixinInstance.UniqueId);
						}
						set {
							base.ExecutePropertySet ("UniqueId", value, v => _mixinInstance.UniqueId = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String TransactionId {
						get {
							return base.ExecutePropertyGet ("TransactionId", () => _mixinInstance.TransactionId);
						}
						set {
							base.ExecutePropertySet ("TransactionId", value, v => _mixinInstance.TransactionId = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String Mode {
						get {
							return base.ExecutePropertyGet ("Mode", () => _mixinInstance.Mode);
						}
						set {
							base.ExecutePropertySet ("Mode", value, v => _mixinInstance.Mode = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.DateTime Time {
						get {
							return base.ExecutePropertyGet ("Time", () => _mixinInstance.Time);
						}
						set {
							base.ExecutePropertySet ("Time", value, v => _mixinInstance.Time = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String ProxyTime {
						get {
							return base.ExecutePropertyGet ("ProxyTime", () => _mixinInstance.ProxyTime);
						}
						set {
							base.ExecutePropertySet ("ProxyTime", value, v => _mixinInstance.ProxyTime = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String Descriptor {
						get {
							return base.ExecutePropertyGet ("Descriptor", () => _mixinInstance.Descriptor);
						}
						set {
							base.ExecutePropertySet ("Descriptor", value, v => _mixinInstance.Descriptor = v);
						}
					}
				}
			}
			public sealed class Genesis_Net_Entities_Responses_AsyncTransactionModel
			{
				public class AsyncTransactionModelMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public AsyncTransactionModelMasterWrapper (pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.AsyncTransactionModel.IAsyncTransactionModelRequirements target)
					{
						_mixinInstance = base.TryActivateMixin<pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.AsyncTransactionModel.AsyncTransactionModelAbstractWrapper> (target);
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::Genesis.Net.Entities.Responses.AsyncTransactionModel _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String RedirectUrl {
						get {
							return base.ExecutePropertyGet ("RedirectUrl", () => _mixinInstance.RedirectUrl);
						}
						set {
							base.ExecutePropertySet ("RedirectUrl", value, v => _mixinInstance.RedirectUrl = v);
						}
					}
				}
			}
			public sealed class Genesis_Net_Entities_Responses_TransactionStatusModel
			{
				public class TransactionStatusModelMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public TransactionStatusModelMasterWrapper (pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionStatusModel.ITransactionStatusModelRequirements target)
					{
						_mixinInstance = base.TryActivateMixin<pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionStatusModel.TransactionStatusModelAbstractWrapper> (target);
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::Genesis.Net.Entities.Responses.TransactionStatusModel _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String Status {
						get {
							return base.ExecutePropertyGet ("Status", () => _mixinInstance.Status);
						}
						set {
							base.ExecutePropertySet ("Status", value, v => _mixinInstance.Status = v);
						}
					}
				}
			}
			public sealed class Genesis_Net_Entities_Responses_MoneyModel
			{
				public class MoneyModelMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public MoneyModelMasterWrapper (pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.MoneyModel.IMoneyModelRequirements target)
					{
						_mixinInstance = base.TryActivateMixin<pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.MoneyModel.MoneyModelAbstractWrapper> (target);
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::Genesis.Net.Entities.Responses.MoneyModel _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.Decimal Amount {
						get {
							return base.ExecutePropertyGet ("Amount", () => _mixinInstance.Amount);
						}
						set {
							base.ExecutePropertySet ("Amount", value, v => _mixinInstance.Amount = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String ProxyAmount {
						get {
							return base.ExecutePropertyGet ("ProxyAmount", () => _mixinInstance.ProxyAmount);
						}
						set {
							base.ExecutePropertySet ("ProxyAmount", value, v => _mixinInstance.ProxyAmount = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::Genesis.Net.Common.Iso4217CurrencyCodes Currency {
						get {
							return base.ExecutePropertyGet ("Currency", () => _mixinInstance.Currency);
						}
						set {
							base.ExecutePropertySet ("Currency", value, v => _mixinInstance.Currency = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.Nullable<global::System.Boolean> PartialApproval {
						get {
							return base.ExecutePropertyGet ("PartialApproval", () => _mixinInstance.PartialApproval);
						}
						set {
							base.ExecutePropertySet ("PartialApproval", value, v => _mixinInstance.PartialApproval = v);
						}
					}
				}
			}
			public sealed class Genesis_Net_Entities_Responses_ErrorModel
			{
				public class ErrorModelMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public ErrorModelMasterWrapper (pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.ErrorModel.IErrorModelRequirements target)
					{
						_mixinInstance = base.TryActivateMixin<pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.ErrorModel.ErrorModelAbstractWrapper> (target);
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::Genesis.Net.Entities.Responses.ErrorModel _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::Genesis.Net.Errors.ErrorCodes Code {
						get {
							return base.ExecutePropertyGet ("Code", () => _mixinInstance.Code);
						}
						set {
							base.ExecutePropertySet ("Code", value, v => _mixinInstance.Code = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.Int32 ProxyCode {
						get {
							return base.ExecutePropertyGet ("ProxyCode", () => _mixinInstance.ProxyCode);
						}
						set {
							base.ExecutePropertySet ("ProxyCode", value, v => _mixinInstance.ProxyCode = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String TechnicalMessage {
						get {
							return base.ExecutePropertyGet ("TechnicalMessage", () => _mixinInstance.TechnicalMessage);
						}
						set {
							base.ExecutePropertySet ("TechnicalMessage", value, v => _mixinInstance.TechnicalMessage = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String Message {
						get {
							return base.ExecutePropertyGet ("Message", () => _mixinInstance.Message);
						}
						set {
							base.ExecutePropertySet ("Message", value, v => _mixinInstance.Message = v);
						}
					}
				}
			}
		}
		private __Mixins ____mixins;
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		private __Mixins __mixins {
			get {
				if (null == ____mixins) {
					lock (__Mixins.____Lock) {
						if (null == ____mixins) {
							____mixins = new __Mixins (this);
							____mixins.__ActivateMixinDependencies (this);
						}
					}
				}
				return ____mixins;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		global::Genesis.Net.Entities.Responses.TransactionModel global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.TransactionModel>.MixinInstance {
			get {
				return __mixins.Genesis_Net_Entities_Responses_TransactionModel._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		global::Genesis.Net.Entities.Responses.AsyncTransactionModel global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.AsyncTransactionModel>.MixinInstance {
			get {
				return __mixins.Genesis_Net_Entities_Responses_AsyncTransactionModel._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		global::Genesis.Net.Entities.Responses.TransactionStatusModel global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.TransactionStatusModel>.MixinInstance {
			get {
				return __mixins.Genesis_Net_Entities_Responses_TransactionStatusModel._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		global::Genesis.Net.Entities.Responses.MoneyModel global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.MoneyModel>.MixinInstance {
			get {
				return __mixins.Genesis_Net_Entities_Responses_MoneyModel._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		global::Genesis.Net.Entities.Responses.ErrorModel global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.ErrorModel>.MixinInstance {
			get {
				return __mixins.Genesis_Net_Entities_Responses_ErrorModel._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "unique_id")]
		public global::System.String UniqueId {
			get {
				return __mixins.Genesis_Net_Entities_Responses_TransactionModel.UniqueId;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_TransactionModel.UniqueId = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "transaction_id")]
		public global::System.String TransactionId {
			get {
				return __mixins.Genesis_Net_Entities_Responses_TransactionModel.TransactionId;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_TransactionModel.TransactionId = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "mode")]
		public global::System.String Mode {
			get {
				return __mixins.Genesis_Net_Entities_Responses_TransactionModel.Mode;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_TransactionModel.Mode = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public global::System.DateTime Time {
			get {
				return __mixins.Genesis_Net_Entities_Responses_TransactionModel.Time;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_TransactionModel.Time = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "timestamp")]
		public global::System.String ProxyTime {
			get {
				return __mixins.Genesis_Net_Entities_Responses_TransactionModel.ProxyTime;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_TransactionModel.ProxyTime = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "descriptor")]
		public global::System.String Descriptor {
			get {
				return __mixins.Genesis_Net_Entities_Responses_TransactionModel.Descriptor;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_TransactionModel.Descriptor = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "redirect_url")]
		public global::System.String RedirectUrl {
			get {
				return __mixins.Genesis_Net_Entities_Responses_AsyncTransactionModel.RedirectUrl;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_AsyncTransactionModel.RedirectUrl = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "status")]
		public global::System.String Status {
			get {
				return __mixins.Genesis_Net_Entities_Responses_TransactionStatusModel.Status;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_TransactionStatusModel.Status = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public global::System.Decimal Amount {
			get {
				return __mixins.Genesis_Net_Entities_Responses_MoneyModel.Amount;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_MoneyModel.Amount = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "amount")]
		public global::System.String ProxyAmount {
			get {
				return __mixins.Genesis_Net_Entities_Responses_MoneyModel.ProxyAmount;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_MoneyModel.ProxyAmount = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "currency")]
		public global::Genesis.Net.Common.Iso4217CurrencyCodes Currency {
			get {
				return __mixins.Genesis_Net_Entities_Responses_MoneyModel.Currency;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_MoneyModel.Currency = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "partial_approval")]
		public global::System.Nullable<global::System.Boolean> PartialApproval {
			get {
				return __mixins.Genesis_Net_Entities_Responses_MoneyModel.PartialApproval;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_MoneyModel.PartialApproval = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public global::Genesis.Net.Errors.ErrorCodes Code {
			get {
				return __mixins.Genesis_Net_Entities_Responses_ErrorModel.Code;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_ErrorModel.Code = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "code")]
		public global::System.Int32 ProxyCode {
			get {
				return __mixins.Genesis_Net_Entities_Responses_ErrorModel.ProxyCode;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_ErrorModel.ProxyCode = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "technical_message")]
		public global::System.String TechnicalMessage {
			get {
				return __mixins.Genesis_Net_Entities_Responses_ErrorModel.TechnicalMessage;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_ErrorModel.TechnicalMessage = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "message")]
		public global::System.String Message {
			get {
				return __mixins.Genesis_Net_Entities_Responses_ErrorModel.Message;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_ErrorModel.Message = value;
			}
		}
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.__Shared
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionModel
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface ITransactionModelRequirements : global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionModel
{
	internal abstract class TransactionModelProtectedMembersWrapper : global::Genesis.Net.Entities.Responses.TransactionModel
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionModel
{
	internal class TransactionModelAbstractWrapper : TransactionModelProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionModel.ITransactionModelRequirements _target;
		public TransactionModelAbstractWrapper (global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionModel.ITransactionModelRequirements target) : base ()
		{
			_target = target;
		}
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.AsyncTransactionModel
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface IAsyncTransactionModelRequirements : global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.AsyncTransactionModel
{
	internal abstract class AsyncTransactionModelProtectedMembersWrapper : global::Genesis.Net.Entities.Responses.AsyncTransactionModel
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.AsyncTransactionModel
{
	internal class AsyncTransactionModelAbstractWrapper : AsyncTransactionModelProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.AsyncTransactionModel.IAsyncTransactionModelRequirements _target;
		public AsyncTransactionModelAbstractWrapper (global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.AsyncTransactionModel.IAsyncTransactionModelRequirements target) : base ()
		{
			_target = target;
		}
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionStatusModel
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface ITransactionStatusModelRequirements : global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionStatusModel
{
	internal abstract class TransactionStatusModelProtectedMembersWrapper : global::Genesis.Net.Entities.Responses.TransactionStatusModel
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionStatusModel
{
	internal class TransactionStatusModelAbstractWrapper : TransactionStatusModelProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionStatusModel.ITransactionStatusModelRequirements _target;
		public TransactionStatusModelAbstractWrapper (global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.TransactionStatusModel.ITransactionStatusModelRequirements target) : base ()
		{
			_target = target;
		}
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.MoneyModel
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface IMoneyModelRequirements : global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.MoneyModel
{
	internal abstract class MoneyModelProtectedMembersWrapper : global::Genesis.Net.Entities.Responses.MoneyModel
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.MoneyModel
{
	internal class MoneyModelAbstractWrapper : MoneyModelProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.MoneyModel.IMoneyModelRequirements _target;
		public MoneyModelAbstractWrapper (global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.MoneyModel.IMoneyModelRequirements target) : base ()
		{
			_target = target;
		}
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.ErrorModel
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface IErrorModelRequirements : global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.ErrorModel
{
	internal abstract class ErrorModelProtectedMembersWrapper : global::Genesis.Net.Entities.Responses.ErrorModel
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.ErrorModel
{
	internal class ErrorModelAbstractWrapper : ErrorModelProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.ErrorModel.IErrorModelRequirements _target;
		public ErrorModelAbstractWrapper (global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.WpfCreateSuccessResponse.Genesis.Net.Entities.Responses.ErrorModel.IErrorModelRequirements target) : base ()
		{
			_target = target;
		}
	}
}
