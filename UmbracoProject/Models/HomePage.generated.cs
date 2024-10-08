//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Home Page</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public HomePage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// About us - Form Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsFormButtonText")]
		public virtual string AboutUsFormButtonText => this.Value<string>(_publishedValueFallback, "aboutUsFormButtonText");

		///<summary>
		/// About us - Form Input Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsFormInputEmail")]
		public virtual string AboutUsFormInputEmail => this.Value<string>(_publishedValueFallback, "aboutUsFormInputEmail");

		///<summary>
		/// About us - Form Input Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsFormInputName")]
		public virtual string AboutUsFormInputName => this.Value<string>(_publishedValueFallback, "aboutUsFormInputName");

		///<summary>
		/// About us - Form Input Phone
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsFormInputPhone")]
		public virtual string AboutUsFormInputPhone => this.Value<string>(_publishedValueFallback, "aboutUsFormInputPhone");

		///<summary>
		/// About us - Form Input Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsFormInputType")]
		public virtual string AboutUsFormInputType => this.Value<string>(_publishedValueFallback, "aboutUsFormInputType");

		///<summary>
		/// About us - Form Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsFormText")]
		public virtual string AboutUsFormText => this.Value<string>(_publishedValueFallback, "aboutUsFormText");

		///<summary>
		/// About us - Form Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsFormTitle")]
		public virtual string AboutUsFormTitle => this.Value<string>(_publishedValueFallback, "aboutUsFormTitle");

		///<summary>
		/// About us - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsHeadline")]
		public virtual string AboutUsHeadline => this.Value<string>(_publishedValueFallback, "aboutUsHeadline");

		///<summary>
		/// About us - Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsLabel")]
		public virtual string AboutUsLabel => this.Value<string>(_publishedValueFallback, "aboutUsLabel");

		///<summary>
		/// About us - Quotation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsQuotation")]
		public virtual string AboutUsQuotation => this.Value<string>(_publishedValueFallback, "aboutUsQuotation");

		///<summary>
		/// About us - Signature Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsSignatureImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops AboutUsSignatureImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "aboutUsSignatureImage");

		///<summary>
		/// About us - Signature Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsSignatureText")]
		public virtual string AboutUsSignatureText => this.Value<string>(_publishedValueFallback, "aboutUsSignatureText");

		///<summary>
		/// About us - Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsText")]
		public virtual string AboutUsText => this.Value<string>(_publishedValueFallback, "aboutUsText");

		///<summary>
		/// Hero - Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroButtonText")]
		public virtual string HeroButtonText => this.Value<string>(_publishedValueFallback, "heroButtonText");

		///<summary>
		/// Hero - Button Url
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroButtonUrl")]
		public virtual string HeroButtonUrl => this.Value<string>(_publishedValueFallback, "heroButtonUrl");

		///<summary>
		/// Hero - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroHeadline")]
		public virtual string HeroHeadline => this.Value<string>(_publishedValueFallback, "heroHeadline");

		///<summary>
		/// Hero - Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HeroImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "heroImage");

		///<summary>
		/// Hero - Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroText")]
		public virtual string HeroText => this.Value<string>(_publishedValueFallback, "heroText");

		///<summary>
		/// Our Story - Background Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourStoryBackgroundImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurStoryBackgroundImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourStoryBackgroundImage");

		///<summary>
		/// Our Story - Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourStoryButtonText")]
		public virtual string OurStoryButtonText => this.Value<string>(_publishedValueFallback, "ourStoryButtonText");

		///<summary>
		/// Our Story - Headline Bot
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourStoryHeadlineBot")]
		public virtual string OurStoryHeadlineBot => this.Value<string>(_publishedValueFallback, "ourStoryHeadlineBot");

		///<summary>
		/// Our Story - Headline Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourStoryHeadlineTop")]
		public virtual string OurStoryHeadlineTop => this.Value<string>(_publishedValueFallback, "ourStoryHeadlineTop");

		///<summary>
		/// Our Story - Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourStoryImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurStoryImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourStoryImage");

		///<summary>
		/// Our Story - Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourStoryText")]
		public virtual string OurStoryText => this.Value<string>(_publishedValueFallback, "ourStoryText");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// Recent Projects - Carousel Images
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsCarouselImages")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> RecentProjectsCarouselImages => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops>>(_publishedValueFallback, "recentProjectsCarouselImages");

		///<summary>
		/// Recent Projects - Company Images
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsCompanyImages")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> RecentProjectsCompanyImages => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops>>(_publishedValueFallback, "recentProjectsCompanyImages");

		///<summary>
		/// Recent Projects - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsHeadline")]
		public virtual string RecentProjectsHeadline => this.Value<string>(_publishedValueFallback, "recentProjectsHeadline");

		///<summary>
		/// Recent Projects - Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsLabel")]
		public virtual string RecentProjectsLabel => this.Value<string>(_publishedValueFallback, "recentProjectsLabel");

		///<summary>
		/// Service Section - Background Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceSectionBackgroundColor")]
		public virtual string ServiceSectionBackgroundColor => this.Value<string>(_publishedValueFallback, "serviceSectionBackgroundColor");

		///<summary>
		/// Service Section - Card Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceSectionCardContent")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel ServiceSectionCardContent => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(_publishedValueFallback, "serviceSectionCardContent");

		///<summary>
		/// Service Section - Card Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceSectionCardText")]
		public virtual string ServiceSectionCardText => this.Value<string>(_publishedValueFallback, "serviceSectionCardText");

		///<summary>
		/// Service Section - Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceSectionLabel")]
		public virtual string ServiceSectionLabel => this.Value<string>(_publishedValueFallback, "serviceSectionLabel");

		///<summary>
		/// Service Section - Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceSectionTitle")]
		public virtual string ServiceSectionTitle => this.Value<string>(_publishedValueFallback, "serviceSectionTitle");

		///<summary>
		/// Success Story - Background Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryBackgroundImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SuccessStoryBackgroundImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "successStoryBackgroundImage");

		///<summary>
		/// Success Story - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryHeadline")]
		public virtual string SuccessStoryHeadline => this.Value<string>(_publishedValueFallback, "successStoryHeadline");

		///<summary>
		/// Success Story - Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SuccessStoryImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "successStoryImage");

		///<summary>
		/// Success Story - Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryLabel")]
		public virtual string SuccessStoryLabel => this.Value<string>(_publishedValueFallback, "successStoryLabel");

		///<summary>
		/// Success Story - Numbers
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryNumbers")]
		public virtual global::System.Collections.Generic.IEnumerable<string> SuccessStoryNumbers => this.Value<global::System.Collections.Generic.IEnumerable<string>>(_publishedValueFallback, "successStoryNumbers");

		///<summary>
		/// Success Story - Texts
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryTexts")]
		public virtual global::System.Collections.Generic.IEnumerable<string> SuccessStoryTexts => this.Value<global::System.Collections.Generic.IEnumerable<string>>(_publishedValueFallback, "successStoryTexts");
	}
}
