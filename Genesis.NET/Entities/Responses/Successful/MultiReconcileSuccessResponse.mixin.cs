//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CopaceticSoftware.pMixins.CodeGenerator v0.6.0.457
//      for file genesis_dotnet\Genesis.NET\Entities\Responses\Successful\MultiReconcileSuccessResponse.cs.
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.  
// </auto-generated> 
//------------------------------------------------------------------------------
namespace Genesis.Net.Entities.Responses.Successful
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public partial class MultiReconcileSuccessResponse : pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.ItemsRangeModel.IItemsRangeModelRequirements, pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.PaymentResponseModel.IPaymentResponseModelRequirements, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.ItemsRangeModel>, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.PaymentResponseModel>
	{
		private sealed class __Mixins
		{
			public static global::System.Object ____Lock = new global::System.Object ();
			public __pMixinAutoGenerated.Genesis_Net_Entities_Responses_ItemsRangeModel.ItemsRangeModelMasterWrapper Genesis_Net_Entities_Responses_ItemsRangeModel;
			public __pMixinAutoGenerated.Genesis_Net_Entities_Responses_PaymentResponseModel.PaymentResponseModelMasterWrapper Genesis_Net_Entities_Responses_PaymentResponseModel;
			public __Mixins (MultiReconcileSuccessResponse target)
			{
				Genesis_Net_Entities_Responses_ItemsRangeModel = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.Genesis_Net_Entities_Responses_ItemsRangeModel.ItemsRangeModelMasterWrapper> ((pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.ItemsRangeModel.IItemsRangeModelRequirements)target);
				Genesis_Net_Entities_Responses_PaymentResponseModel = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.Genesis_Net_Entities_Responses_PaymentResponseModel.PaymentResponseModelMasterWrapper> ((pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.PaymentResponseModel.IPaymentResponseModelRequirements)target);
			}
			[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
			[global::System.Diagnostics.DebuggerStepThrough]
			public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse target)
			{
				Genesis_Net_Entities_Responses_ItemsRangeModel.__ActivateMixinDependencies (target);
				Genesis_Net_Entities_Responses_PaymentResponseModel.__ActivateMixinDependencies (target);
			}
		}
		private sealed class __pMixinAutoGenerated
		{
			public sealed class Genesis_Net_Entities_Responses_ItemsRangeModel
			{
				public class ItemsRangeModelMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public ItemsRangeModelMasterWrapper (pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.ItemsRangeModel.IItemsRangeModelRequirements target)
					{
						_mixinInstance = base.TryActivateMixin<pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.ItemsRangeModel.ItemsRangeModelAbstractWrapper> (target);
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::Genesis.Net.Entities.Responses.ItemsRangeModel _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.Int32 ItemsPerPage {
						get {
							return base.ExecutePropertyGet ("ItemsPerPage", () => _mixinInstance.ItemsPerPage);
						}
						set {
							base.ExecutePropertySet ("ItemsPerPage", value, v => _mixinInstance.ItemsPerPage = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.Int32 PageNumber {
						get {
							return base.ExecutePropertyGet ("PageNumber", () => _mixinInstance.PageNumber);
						}
						set {
							base.ExecutePropertySet ("PageNumber", value, v => _mixinInstance.PageNumber = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.Int32 TotalCount {
						get {
							return base.ExecutePropertyGet ("TotalCount", () => _mixinInstance.TotalCount);
						}
						set {
							base.ExecutePropertySet ("TotalCount", value, v => _mixinInstance.TotalCount = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.Int32 PagesCount {
						get {
							return base.ExecutePropertyGet ("PagesCount", () => _mixinInstance.PagesCount);
						}
						set {
							base.ExecutePropertySet ("PagesCount", value, v => _mixinInstance.PagesCount = v);
						}
					}
				}
			}
			public sealed class Genesis_Net_Entities_Responses_PaymentResponseModel
			{
				public class PaymentResponseModelMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public PaymentResponseModelMasterWrapper (pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.PaymentResponseModel.IPaymentResponseModelRequirements target)
					{
						_mixinInstance = base.TryActivateMixin<pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.PaymentResponseModel.PaymentResponseModelAbstractWrapper> (target);
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::Genesis.Net.Entities.Responses.PaymentResponseModel _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::Genesis.Net.Entities.Responses.PaymentResponse[] Payments {
						get {
							return base.ExecutePropertyGet ("Payments", () => _mixinInstance.Payments);
						}
						set {
							base.ExecutePropertySet ("Payments", value, v => _mixinInstance.Payments = v);
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
		global::Genesis.Net.Entities.Responses.ItemsRangeModel global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.ItemsRangeModel>.MixinInstance {
			get {
				return __mixins.Genesis_Net_Entities_Responses_ItemsRangeModel._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		global::Genesis.Net.Entities.Responses.PaymentResponseModel global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.PaymentResponseModel>.MixinInstance {
			get {
				return __mixins.Genesis_Net_Entities_Responses_PaymentResponseModel._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlAttributeAttribute (AttributeName = "per_page")]
		public global::System.Int32 ItemsPerPage {
			get {
				return __mixins.Genesis_Net_Entities_Responses_ItemsRangeModel.ItemsPerPage;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_ItemsRangeModel.ItemsPerPage = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlAttributeAttribute (AttributeName = "page")]
		public global::System.Int32 PageNumber {
			get {
				return __mixins.Genesis_Net_Entities_Responses_ItemsRangeModel.PageNumber;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_ItemsRangeModel.PageNumber = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlAttributeAttribute (AttributeName = "total_count")]
		public global::System.Int32 TotalCount {
			get {
				return __mixins.Genesis_Net_Entities_Responses_ItemsRangeModel.TotalCount;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_ItemsRangeModel.TotalCount = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlAttributeAttribute (AttributeName = "pages_count")]
		public global::System.Int32 PagesCount {
			get {
				return __mixins.Genesis_Net_Entities_Responses_ItemsRangeModel.PagesCount;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_ItemsRangeModel.PagesCount = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "payment_response")]
		public global::Genesis.Net.Entities.Responses.PaymentResponse[] Payments {
			get {
				return __mixins.Genesis_Net_Entities_Responses_PaymentResponseModel.Payments;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_PaymentResponseModel.Payments = value;
			}
		}
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.__Shared
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.ItemsRangeModel
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface IItemsRangeModelRequirements : global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.ItemsRangeModel
{
	internal abstract class ItemsRangeModelProtectedMembersWrapper : global::Genesis.Net.Entities.Responses.ItemsRangeModel
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.ItemsRangeModel
{
	internal class ItemsRangeModelAbstractWrapper : ItemsRangeModelProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.ItemsRangeModel.IItemsRangeModelRequirements _target;
		public ItemsRangeModelAbstractWrapper (global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.ItemsRangeModel.IItemsRangeModelRequirements target) : base ()
		{
			_target = target;
		}
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.PaymentResponseModel
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface IPaymentResponseModelRequirements : global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.PaymentResponseModel
{
	internal abstract class PaymentResponseModelProtectedMembersWrapper : global::Genesis.Net.Entities.Responses.PaymentResponseModel
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.PaymentResponseModel
{
	internal class PaymentResponseModelAbstractWrapper : PaymentResponseModelProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.PaymentResponseModel.IPaymentResponseModelRequirements _target;
		public PaymentResponseModelAbstractWrapper (global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.MultiReconcileSuccessResponse.Genesis.Net.Entities.Responses.PaymentResponseModel.IPaymentResponseModelRequirements target) : base ()
		{
			_target = target;
		}
	}
}
