namespace Magellanic.Web.Mvc.Rendering
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Runtime.InteropServices;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    /// <summary>
    /// Extensions related to the HTML Select element for HtmlHelper.
    /// </summary>
    public static partial class HtmlHelperSelectExtensions
    {
        /// <summary>
        /// Returns a single-selection HTML &lt;select&gt; element for the expression <paramref name="name" />,
        /// using the specified list items.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TListItemType">The type of the items in the list.</typeparam>
        /// <typeparam name="TItemId">The type of the item identifier.</typeparam>
        /// <typeparam name="TItemName">The type of the item name.</typeparam>
        /// <typeparam name="TSelectedValue">The type of the selected value expression result.</typeparam>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="formFieldName">Name of the form field.</param>
        /// <param name="items">The items to put in the  HTML &lt;select&gt; element.</param>
        /// <param name="optionValueProperty">The item identifier property.</param>
        /// <param name="optionInnerHTMLProperty">The item name property.</param>
        /// <param name="optionLabel">The text for a default empty item. Does not include such an item if argument is <c>null</c>.</param>
        /// <param name="htmlAttributes">An <see cref="object" /> that contains the HTML attributes for the &lt;select&gt; element. Alternatively, an
        /// <see cref="IDictionary{string, object}" /> instance containing the HTML attributes.</param>
        /// <returns>A new MvcHtmlString containing the &lt;select&gt; element.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static MvcHtmlString DropDownListFor<TModel, TListItemType, TItemId, TItemName, TSelectedValue>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TSelectedValue>> formFieldName,
            Expression<Func<TModel, ICollection<TListItemType>>> items,
            Expression<Func<TListItemType, TItemId>> optionValueProperty,
            Expression<Func<TListItemType, TItemName>> optionInnerHtmlProperty,
            [Optional] string optionLabel,
            [Optional] object htmlAttributes)
        {
            if (htmlHelper == null)
            {
                throw new ArgumentNullException(paramName: "htmlHelper", message: "The static Html Helper is null.");
            }

            var formField = ExpressionHelper.GetExpressionText(formFieldName);
            var itemIdPropertyName = ExpressionHelper.GetExpressionText(optionValueProperty);
            var itemNamePropertyName = ExpressionHelper.GetExpressionText(optionInnerHtmlProperty);

            var listItemsModel = GetModelFromExpressionAndViewData(items, htmlHelper.ViewData) as List<TListItemType>;

            // if the list is null, initialize to an empty list so we display something
            if (listItemsModel == null)
            {
                listItemsModel = new List<TListItemType>();
            }

            var selectedValueObject = GetModelFromExpressionAndViewData(formFieldName, htmlHelper.ViewData);

            var selectList = new SelectList(listItemsModel, itemIdPropertyName, itemNamePropertyName, selectedValueObject);

            return SelectExtensions.DropDownList(htmlHelper: htmlHelper, name: formField, selectList: selectList, optionLabel: optionLabel, htmlAttributes: htmlAttributes);
        }

        /// <summary>
        /// Gets the model from expression and view data.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TSelectedValue">The type of the selected value expression result.</typeparam>
        /// <param name="expressionThatDefinesTheModel">The expression that defines the model.</param>
        /// <param name="viewDataDictionary">The view data dictionary.</param>
        /// <returns>System.Object.</returns>
        private static object GetModelFromExpressionAndViewData<TModel, TSelectedValue>(Expression<Func<TModel, TSelectedValue>> expressionThatDefinesTheModel, ViewDataDictionary<TModel> viewDataDictionary)
        {
            var metaData = ModelMetadata.FromLambdaExpression(expressionThatDefinesTheModel, viewDataDictionary);

            return metaData.Model;
        }
    }
}