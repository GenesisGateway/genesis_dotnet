//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CopaceticSoftware.pMixins.CodeGenerator v0.6.0.457
//      for file genesis_dotnet\Genesis.NET\Entities\Responses\Successful\GooglePaySuccessResponse.cs.
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.  
// </auto-generated> 
//------------------------------------------------------------------------------
namespace Genesis.Net.Entities.Responses.Successful
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public partial class GooglePaySuccessResponse : pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AvsResponseModel.IAvsResponseModelRequirements, pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AuthorizationModel.IAuthorizationModelRequirements, pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.ConsumerModel.IConsumerModelRequirements, pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.IssuerModel.IIssuerModelRequirements, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.AvsResponseModel>, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.AuthorizationModel>, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.ConsumerModel>, global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.IssuerModel>
	{
		private sealed class __Mixins
		{
			public static global::System.Object ____Lock = new global::System.Object ();
			public __pMixinAutoGenerated.Genesis_Net_Entities_Responses_AvsResponseModel.AvsResponseModelMasterWrapper Genesis_Net_Entities_Responses_AvsResponseModel;
			public __pMixinAutoGenerated.Genesis_Net_Entities_Responses_AuthorizationModel.AuthorizationModelMasterWrapper Genesis_Net_Entities_Responses_AuthorizationModel;
			public __pMixinAutoGenerated.Genesis_Net_Entities_Responses_ConsumerModel.ConsumerModelMasterWrapper Genesis_Net_Entities_Responses_ConsumerModel;
			public __pMixinAutoGenerated.Genesis_Net_Entities_Responses_IssuerModel.IssuerModelMasterWrapper Genesis_Net_Entities_Responses_IssuerModel;
			public __Mixins (GooglePaySuccessResponse target)
			{
				Genesis_Net_Entities_Responses_AvsResponseModel = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.Genesis_Net_Entities_Responses_AvsResponseModel.AvsResponseModelMasterWrapper> ((pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AvsResponseModel.IAvsResponseModelRequirements)target);
				Genesis_Net_Entities_Responses_AuthorizationModel = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.Genesis_Net_Entities_Responses_AuthorizationModel.AuthorizationModelMasterWrapper> ((pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AuthorizationModel.IAuthorizationModelRequirements)target);
				Genesis_Net_Entities_Responses_ConsumerModel = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.Genesis_Net_Entities_Responses_ConsumerModel.ConsumerModelMasterWrapper> ((pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.ConsumerModel.IConsumerModelRequirements)target);
				Genesis_Net_Entities_Responses_IssuerModel = global::CopaceticSoftware.pMixins.Infrastructure.MixinActivatorFactory.GetCurrentActivator ().CreateInstance<__pMixinAutoGenerated.Genesis_Net_Entities_Responses_IssuerModel.IssuerModelMasterWrapper> ((pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.IssuerModel.IIssuerModelRequirements)target);
			}
			[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
			[global::System.Diagnostics.DebuggerStepThrough]
			public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse target)
			{
				Genesis_Net_Entities_Responses_AvsResponseModel.__ActivateMixinDependencies (target);
				Genesis_Net_Entities_Responses_AuthorizationModel.__ActivateMixinDependencies (target);
				Genesis_Net_Entities_Responses_ConsumerModel.__ActivateMixinDependencies (target);
				Genesis_Net_Entities_Responses_IssuerModel.__ActivateMixinDependencies (target);
			}
		}
		private sealed class __pMixinAutoGenerated
		{
			public sealed class Genesis_Net_Entities_Responses_AvsResponseModel
			{
				public class AvsResponseModelMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public AvsResponseModelMasterWrapper (pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AvsResponseModel.IAvsResponseModelRequirements target)
					{
						_mixinInstance = base.TryActivateMixin<pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AvsResponseModel.AvsResponseModelAbstractWrapper> (target);
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::Genesis.Net.Entities.Responses.AvsResponseModel _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String AvsResponseCode {
						get {
							return base.ExecutePropertyGet ("AvsResponseCode", () => _mixinInstance.AvsResponseCode);
						}
						set {
							base.ExecutePropertySet ("AvsResponseCode", value, v => _mixinInstance.AvsResponseCode = v);
						}
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String AvsResponseText {
						get {
							return base.ExecutePropertyGet ("AvsResponseText", () => _mixinInstance.AvsResponseText);
						}
						set {
							base.ExecutePropertySet ("AvsResponseText", value, v => _mixinInstance.AvsResponseText = v);
						}
					}
				}
			}
			public sealed class Genesis_Net_Entities_Responses_AuthorizationModel
			{
				public class AuthorizationModelMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public AuthorizationModelMasterWrapper (pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AuthorizationModel.IAuthorizationModelRequirements target)
					{
						_mixinInstance = base.TryActivateMixin<pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AuthorizationModel.AuthorizationModelAbstractWrapper> (target);
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::Genesis.Net.Entities.Responses.AuthorizationModel _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String AuthorizationCode {
						get {
							return base.ExecutePropertyGet ("AuthorizationCode", () => _mixinInstance.AuthorizationCode);
						}
						set {
							base.ExecutePropertySet ("AuthorizationCode", value, v => _mixinInstance.AuthorizationCode = v);
						}
					}
				}
			}
			public sealed class Genesis_Net_Entities_Responses_ConsumerModel
			{
				public class ConsumerModelMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public ConsumerModelMasterWrapper (pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.ConsumerModel.IConsumerModelRequirements target)
					{
						_mixinInstance = base.TryActivateMixin<pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.ConsumerModel.ConsumerModelAbstractWrapper> (target);
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::Genesis.Net.Entities.ConsumerModel _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String ConsumerId {
						get {
							return base.ExecutePropertyGet ("ConsumerId", () => _mixinInstance.ConsumerId);
						}
						set {
							base.ExecutePropertySet ("ConsumerId", value, v => _mixinInstance.ConsumerId = v);
						}
					}
				}
			}
			public sealed class Genesis_Net_Entities_Responses_IssuerModel
			{
				public class IssuerModelMasterWrapper : global::CopaceticSoftware.pMixins.Infrastructure.MasterWrapperBase
				{
					public IssuerModelMasterWrapper (pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.IssuerModel.IIssuerModelRequirements target)
					{
						_mixinInstance = base.TryActivateMixin<pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.IssuerModel.IssuerModelAbstractWrapper> (target);
						base.Initialize (target, _mixinInstance, new global::System.Collections.Generic.List<global::CopaceticSoftware.pMixins.Interceptors.IMixinInterceptor> {

						});
					}
					public global::Genesis.Net.Entities.Responses.IssuerModel _mixinInstance;
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					[global::System.Diagnostics.DebuggerStepThrough]
					public void __ActivateMixinDependencies (Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse target)
					{
					}
					[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
					public global::System.String ResponseCode {
						get {
							return base.ExecutePropertyGet ("ResponseCode", () => _mixinInstance.ResponseCode);
						}
						set {
							base.ExecutePropertySet ("ResponseCode", value, v => _mixinInstance.ResponseCode = v);
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
		global::Genesis.Net.Entities.Responses.AvsResponseModel global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.AvsResponseModel>.MixinInstance {
			get {
				return __mixins.Genesis_Net_Entities_Responses_AvsResponseModel._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		global::Genesis.Net.Entities.Responses.AuthorizationModel global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.AuthorizationModel>.MixinInstance {
			get {
				return __mixins.Genesis_Net_Entities_Responses_AuthorizationModel._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		global::Genesis.Net.Entities.ConsumerModel global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.ConsumerModel>.MixinInstance {
			get {
				return __mixins.Genesis_Net_Entities_Responses_ConsumerModel._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		global::Genesis.Net.Entities.Responses.IssuerModel global::CopaceticSoftware.pMixins.ConversionOperators.IContainMixin<global::Genesis.Net.Entities.Responses.IssuerModel>.MixinInstance {
			get {
				return __mixins.Genesis_Net_Entities_Responses_IssuerModel._mixinInstance;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "avs_response_code")]
		public global::System.String AvsResponseCode {
			get {
				return __mixins.Genesis_Net_Entities_Responses_AvsResponseModel.AvsResponseCode;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_AvsResponseModel.AvsResponseCode = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "avs_response_text")]
		public global::System.String AvsResponseText {
			get {
				return __mixins.Genesis_Net_Entities_Responses_AvsResponseModel.AvsResponseText;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_AvsResponseModel.AvsResponseText = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "authorization_code")]
		public global::System.String AuthorizationCode {
			get {
				return __mixins.Genesis_Net_Entities_Responses_AuthorizationModel.AuthorizationCode;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_AuthorizationModel.AuthorizationCode = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "consumer_id")]
		public global::System.String ConsumerId {
			get {
				return __mixins.Genesis_Net_Entities_Responses_ConsumerModel.ConsumerId;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_ConsumerModel.ConsumerId = value;
			}
		}
		[global::CopaceticSoftware.pMixins.Attributes.MixedInMemberAttribute]
		[System.Xml.Serialization.XmlElementAttribute (ElementName = "response_code")]
		public global::System.String ResponseCode {
			get {
				return __mixins.Genesis_Net_Entities_Responses_IssuerModel.ResponseCode;
			}
			set {
				__mixins.Genesis_Net_Entities_Responses_IssuerModel.ResponseCode = value;
			}
		}
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.__Shared
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AvsResponseModel
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface IAvsResponseModelRequirements : global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AvsResponseModel
{
	internal abstract class AvsResponseModelProtectedMembersWrapper : global::Genesis.Net.Entities.Responses.AvsResponseModel
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AvsResponseModel
{
	internal class AvsResponseModelAbstractWrapper : AvsResponseModelProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AvsResponseModel.IAvsResponseModelRequirements _target;
		public AvsResponseModelAbstractWrapper (global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AvsResponseModel.IAvsResponseModelRequirements target) : base ()
		{
			_target = target;
		}
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AuthorizationModel
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface IAuthorizationModelRequirements : global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AuthorizationModel
{
	internal abstract class AuthorizationModelProtectedMembersWrapper : global::Genesis.Net.Entities.Responses.AuthorizationModel
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AuthorizationModel
{
	internal class AuthorizationModelAbstractWrapper : AuthorizationModelProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AuthorizationModel.IAuthorizationModelRequirements _target;
		public AuthorizationModelAbstractWrapper (global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.AuthorizationModel.IAuthorizationModelRequirements target) : base ()
		{
			_target = target;
		}
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.ConsumerModel
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface IConsumerModelRequirements : global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.ConsumerModel
{
	internal abstract class ConsumerModelProtectedMembersWrapper : global::Genesis.Net.Entities.ConsumerModel
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.ConsumerModel
{
	internal class ConsumerModelAbstractWrapper : ConsumerModelProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.ConsumerModel.IConsumerModelRequirements _target;
		public ConsumerModelAbstractWrapper (global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.ConsumerModel.IConsumerModelRequirements target) : base ()
		{
			_target = target;
		}
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.IssuerModel
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute ("pMixin", "0.6.0.457")]
	public interface IIssuerModelRequirements : global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.__Shared.ISharedRequirements
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.IssuerModel
{
	internal abstract class IssuerModelProtectedMembersWrapper : global::Genesis.Net.Entities.Responses.IssuerModel
	{
	}
}
namespace pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.IssuerModel
{
	internal class IssuerModelAbstractWrapper : IssuerModelProtectedMembersWrapper
	{
		private readonly global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.IssuerModel.IIssuerModelRequirements _target;
		public IssuerModelAbstractWrapper (global::pMixins.AutoGenerated.Genesis.Net.Entities.Responses.Successful.GooglePaySuccessResponse.Genesis.Net.Entities.Responses.IssuerModel.IIssuerModelRequirements target) : base ()
		{
			_target = target;
		}
	}
}