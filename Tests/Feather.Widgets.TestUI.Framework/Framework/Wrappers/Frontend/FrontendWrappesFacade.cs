﻿using Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend.CardWidget;
using Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend.Classifications;
using Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend.CommentsAndReviews;
using Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend.EmailCampaigns;
using Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend.Events;
using Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend.FeedWidget;
using Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend.Forms;
using Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend.Identity;
using Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend.Lists;
using Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend.ModuleBuilder;
using Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend.ScriptsAndStyles;

namespace Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend
{
    /// <summary>
    /// This is the entry point class for all frontend wrappers.
    /// </summary>
    public class FrontendWrappesFacade
    {
        /// <summary>
        /// Provides unified access to the ContentBlockWrapperFacade 
        /// </summary>
        /// <returns>Returns the ContentBlockWrapperFacade</returns>
        public ContentBlockWrapperFacade ContentBlock()
        {
            return new ContentBlockWrapperFacade();
        }

        /// <summary>
        /// Provides unified access to the NavigationWrapperFacade 
        /// </summary>
        /// <returns>Returns the NavigationWrapperFacade</returns>
        public NavigationWrapperFacade Navigation()
        {
            return new NavigationWrapperFacade();
        }

        /// <summary>
        /// Provides unified access to the NewsWrapperFacade 
        /// </summary>
        /// <returns>Returns the NewsWrapperFacade</returns>
        public NewsWrapperFacade News()
        {
            return new NewsWrapperFacade();
        }

        /// <summary>
        /// Provides unified access to the ModuleBuilderWrapperFacade 
        /// </summary>
        /// <returns>Returns the ModuleBuilderWrapperFacade</returns>
        public ModuleBuilderWrapperFacade ModuleBuilder()
        {
            return new ModuleBuilderWrapperFacade();
        }

        /// <summary>
        /// Provides unified access to the SocialShareWrapperFacade 
        /// </summary>
        /// <returns></returns>
        public SocialShareWrapperFacade SocialShare()
        {
            return new SocialShareWrapperFacade();
        }

        /// <summary>
        /// Provides unified access to the SearchWrapperFacade 
        /// </summary>
        /// <returns></returns>
        public SearchWrapperFacade Search()
        {
            return new SearchWrapperFacade();
        }

        /// <summary>
        /// Provides access to frontend common wrapper.
        /// </summary>
        /// <returns></returns>
        public FrontendCommonWrapper CommonWrapper()
        {
            return new FrontendCommonWrapper();
        }

        /// <summary>
        /// Provides access to Login and registration widgets wrappers on the frontend.
        /// </summary>
        /// <returns></returns>
        public IdentityWrapperFacade Identity()
        {
            return new IdentityWrapperFacade();
        }

        /// <summary>
        /// Images the gallery.
        /// </summary>
        /// <returns></returns>
        public ImageGalleryWrapperFacade ImageGallery()
        {
            return new ImageGalleryWrapperFacade();
        }

        /// <summary>
        /// Video gallery.
        /// </summary>
        /// <returns></returns>
        public VideoGalleryWrapperFacade VideoGallery()
        {
            return new VideoGalleryWrapperFacade();
        }

        /// <summary>
        /// Medias the widgets.
        /// </summary>
        /// <returns></returns>
        public MediaWidgetsWrapperFacade MediaWidgets()
        {
            return new MediaWidgetsWrapperFacade();
        }

        /// <summary>
        /// Documents the list.
        /// </summary>
        /// <returns></returns>
        public DocumentListWrapperFacade DocumentsList()
        {
            return new DocumentListWrapperFacade();
        }

        /// <summary>
        /// Provides access to lists frontend wrapper. 
        /// </summary>
        /// <returns></returns>
        public ListsWrapperFacade Lists()
        {
            return new ListsWrapperFacade();
        }

        /// <summary>
        /// Provides access to classifications wrapper. 
        /// </summary>
        /// <returns></returns>
        public ClassificationsWrapperFacade Classifications()
        {
            return new ClassificationsWrapperFacade();
        }

        /// <summary>
        /// Provides access to css and javascript frontend wrapper. 
        /// </summary>
        /// <returns></returns>
        public ScriptsAndStylesWrapperFacade ScriptsAndStyles()
        {
            return new ScriptsAndStylesWrapperFacade();
        }

        /// <summary>
        /// Provides access to comments and reviews frontend wrapper. 
        /// </summary>
        /// <returns></returns>
        public CommentsAndReviewsWrapperFacade CommentsAndReviews()
        {
            return new CommentsAndReviewsWrapperFacade();
        }

        /// <summary>
        /// Provides access to subscribe form and unsubscribe frontend wrapper. 
        /// </summary>
        /// <returns></returns>
        public EmailCampaignsWrapperFacade EmailCampaigns()
        {
            return new EmailCampaignsWrapperFacade();
        }

        /// <summary>
        /// Provides access to feed widget frontend wrapper. 
        /// </summary>
        /// <returns></returns>
        public FeedWidgetWrapperFacade FeedWidget()
        {
            return new FeedWidgetWrapperFacade();
        }

        /// <summary>
        /// Provides access to forms frontend wrapper. 
        /// </summary>
        /// <returns></returns>
        public FormsWrapperFacade Forms()
        {
            return new FormsWrapperFacade();
        }

        /// <summary>
        /// Provides access to card frontend wrapper. 
        /// </summary>
        /// <returns></returns>
        public CardWrapperFacade Card()
        {
            return new CardWrapperFacade();
        }

        /// <summary>
        /// Provides unified access to the BlogsWrapperFacade 
        /// </summary>
        /// <returns>Returns the BlogsWrapperFacade</returns>
        public BlogsWrapperFacade Blogs()
        {
            return new BlogsWrapperFacade();
        }

        /// <summary>
        /// Provides unified access to the EventsWrapperFacade 
        /// </summary>
        /// <returns>Returns the EventsWrapperFacade</returns>
        public EventsWrapperFacade Events()
        {
            return new EventsWrapperFacade();
        }
    }
}
