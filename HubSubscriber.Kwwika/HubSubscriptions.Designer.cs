﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("HubSubscriber.Kwwika", "FK_hubsubscriber_Subscriptions_hubsubscriber_Users", "hubsubscriber_Users", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(HubSubscriber.Models.User), "hubsubscriber_Subscriptions", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HubSubscriber.Models.Subscription), true)]

#endregion

namespace HubSubscriber.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class HubSubscriberEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new HubSubscriberEntities object using the connection string found in the 'HubSubscriberEntities' section of the application configuration file.
        /// </summary>
        public HubSubscriberEntities() : base("name=HubSubscriberEntities", "HubSubscriberEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HubSubscriberEntities object.
        /// </summary>
        public HubSubscriberEntities(string connectionString) : base(connectionString, "HubSubscriberEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HubSubscriberEntities object.
        /// </summary>
        public HubSubscriberEntities(EntityConnection connection) : base(connection, "HubSubscriberEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Subscription> SubscriptionsSet
        {
            get
            {
                if ((_SubscriptionsSet == null))
                {
                    _SubscriptionsSet = base.CreateObjectSet<Subscription>("SubscriptionsSet");
                }
                return _SubscriptionsSet;
            }
        }
        private ObjectSet<Subscription> _SubscriptionsSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> UsersSet
        {
            get
            {
                if ((_UsersSet == null))
                {
                    _UsersSet = base.CreateObjectSet<User>("UsersSet");
                }
                return _UsersSet;
            }
        }
        private ObjectSet<User> _UsersSet;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the SubscriptionsSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSubscriptionsSet(Subscription subscription)
        {
            base.AddObject("SubscriptionsSet", subscription);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the UsersSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsersSet(User user)
        {
            base.AddObject("UsersSet", user);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HubSubscriber.Kwwika", Name="Subscription")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Subscription : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Subscription object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="mode">Initial value of the Mode property.</param>
        /// <param name="verify">Initial value of the Verify property.</param>
        /// <param name="topic">Initial value of the Topic property.</param>
        /// <param name="callback">Initial value of the Callback property.</param>
        /// <param name="digest">Initial value of the Digest property.</param>
        /// <param name="verified">Initial value of the Verified property.</param>
        /// <param name="pendingDeletion">Initial value of the PendingDeletion property.</param>
        /// <param name="pubSubHubUser">Initial value of the PubSubHubUser property.</param>
        public static Subscription CreateSubscription(global::System.Int32 id, global::System.String mode, global::System.String verify, global::System.String topic, global::System.String callback, global::System.Boolean digest, global::System.Boolean verified, global::System.Boolean pendingDeletion, global::System.String pubSubHubUser)
        {
            Subscription subscription = new Subscription();
            subscription.Id = id;
            subscription.Mode = mode;
            subscription.Verify = verify;
            subscription.Topic = topic;
            subscription.Callback = callback;
            subscription.Digest = digest;
            subscription.Verified = verified;
            subscription.PendingDeletion = pendingDeletion;
            subscription.PubSubHubUser = pubSubHubUser;
            return subscription;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Mode
        {
            get
            {
                return _Mode;
            }
            set
            {
                OnModeChanging(value);
                ReportPropertyChanging("Mode");
                _Mode = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Mode");
                OnModeChanged();
            }
        }
        private global::System.String _Mode;
        partial void OnModeChanging(global::System.String value);
        partial void OnModeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Verify
        {
            get
            {
                return _Verify;
            }
            set
            {
                OnVerifyChanging(value);
                ReportPropertyChanging("Verify");
                _Verify = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Verify");
                OnVerifyChanged();
            }
        }
        private global::System.String _Verify;
        partial void OnVerifyChanging(global::System.String value);
        partial void OnVerifyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Topic
        {
            get
            {
                return _Topic;
            }
            set
            {
                OnTopicChanging(value);
                ReportPropertyChanging("Topic");
                _Topic = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Topic");
                OnTopicChanged();
            }
        }
        private global::System.String _Topic;
        partial void OnTopicChanging(global::System.String value);
        partial void OnTopicChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Callback
        {
            get
            {
                return _Callback;
            }
            set
            {
                OnCallbackChanging(value);
                ReportPropertyChanging("Callback");
                _Callback = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Callback");
                OnCallbackChanged();
            }
        }
        private global::System.String _Callback;
        partial void OnCallbackChanging(global::System.String value);
        partial void OnCallbackChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Digest
        {
            get
            {
                return _Digest;
            }
            set
            {
                OnDigestChanging(value);
                ReportPropertyChanging("Digest");
                _Digest = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Digest");
                OnDigestChanged();
            }
        }
        private global::System.Boolean _Digest;
        partial void OnDigestChanging(global::System.Boolean value);
        partial void OnDigestChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Hub
        {
            get
            {
                return _Hub;
            }
            set
            {
                OnHubChanging(value);
                ReportPropertyChanging("Hub");
                _Hub = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Hub");
                OnHubChanged();
            }
        }
        private global::System.String _Hub;
        partial void OnHubChanging(global::System.String value);
        partial void OnHubChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Verified
        {
            get
            {
                return _Verified;
            }
            set
            {
                OnVerifiedChanging(value);
                ReportPropertyChanging("Verified");
                _Verified = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Verified");
                OnVerifiedChanged();
            }
        }
        private global::System.Boolean _Verified;
        partial void OnVerifiedChanging(global::System.Boolean value);
        partial void OnVerifiedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> LastUpdated
        {
            get
            {
                return _LastUpdated;
            }
            set
            {
                OnLastUpdatedChanging(value);
                ReportPropertyChanging("LastUpdated");
                _LastUpdated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastUpdated");
                OnLastUpdatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _LastUpdated;
        partial void OnLastUpdatedChanging(Nullable<global::System.DateTime> value);
        partial void OnLastUpdatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean PendingDeletion
        {
            get
            {
                return _PendingDeletion;
            }
            set
            {
                OnPendingDeletionChanging(value);
                ReportPropertyChanging("PendingDeletion");
                _PendingDeletion = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PendingDeletion");
                OnPendingDeletionChanged();
            }
        }
        private global::System.Boolean _PendingDeletion;
        partial void OnPendingDeletionChanging(global::System.Boolean value);
        partial void OnPendingDeletionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PubSubHubUser
        {
            get
            {
                return _PubSubHubUser;
            }
            set
            {
                OnPubSubHubUserChanging(value);
                ReportPropertyChanging("PubSubHubUser");
                _PubSubHubUser = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PubSubHubUser");
                OnPubSubHubUserChanged();
            }
        }
        private global::System.String _PubSubHubUser;
        partial void OnPubSubHubUserChanging(global::System.String value);
        partial void OnPubSubHubUserChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HubSubscriber.Kwwika", "FK_hubsubscriber_Subscriptions_hubsubscriber_Users", "hubsubscriber_Users")]
        public User hubsubscriber_Users
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("HubSubscriber.Kwwika.FK_hubsubscriber_Subscriptions_hubsubscriber_Users", "hubsubscriber_Users").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("HubSubscriber.Kwwika.FK_hubsubscriber_Subscriptions_hubsubscriber_Users", "hubsubscriber_Users").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> hubsubscriber_UsersReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("HubSubscriber.Kwwika.FK_hubsubscriber_Subscriptions_hubsubscriber_Users", "hubsubscriber_Users");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("HubSubscriber.Kwwika.FK_hubsubscriber_Subscriptions_hubsubscriber_Users", "hubsubscriber_Users", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HubSubscriber.Kwwika", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="pubSubHubUser">Initial value of the PubSubHubUser property.</param>
        /// <param name="kwwikaTopic">Initial value of the KwwikaTopic property.</param>
        /// <param name="maxHubSubscriptions">Initial value of the MaxHubSubscriptions property.</param>
        public static User CreateUser(global::System.String pubSubHubUser, global::System.String kwwikaTopic, global::System.Int16 maxHubSubscriptions)
        {
            User user = new User();
            user.PubSubHubUser = pubSubHubUser;
            user.KwwikaTopic = kwwikaTopic;
            user.MaxHubSubscriptions = maxHubSubscriptions;
            return user;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PubSubHubUser
        {
            get
            {
                return _PubSubHubUser;
            }
            set
            {
                if (_PubSubHubUser != value)
                {
                    OnPubSubHubUserChanging(value);
                    ReportPropertyChanging("PubSubHubUser");
                    _PubSubHubUser = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("PubSubHubUser");
                    OnPubSubHubUserChanged();
                }
            }
        }
        private global::System.String _PubSubHubUser;
        partial void OnPubSubHubUserChanging(global::System.String value);
        partial void OnPubSubHubUserChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String KwwikaTopic
        {
            get
            {
                return _KwwikaTopic;
            }
            set
            {
                OnKwwikaTopicChanging(value);
                ReportPropertyChanging("KwwikaTopic");
                _KwwikaTopic = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("KwwikaTopic");
                OnKwwikaTopicChanged();
            }
        }
        private global::System.String _KwwikaTopic;
        partial void OnKwwikaTopicChanging(global::System.String value);
        partial void OnKwwikaTopicChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 MaxHubSubscriptions
        {
            get
            {
                return _MaxHubSubscriptions;
            }
            set
            {
                OnMaxHubSubscriptionsChanging(value);
                ReportPropertyChanging("MaxHubSubscriptions");
                _MaxHubSubscriptions = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MaxHubSubscriptions");
                OnMaxHubSubscriptionsChanged();
            }
        }
        private global::System.Int16 _MaxHubSubscriptions;
        partial void OnMaxHubSubscriptionsChanging(global::System.Int16 value);
        partial void OnMaxHubSubscriptionsChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HubSubscriber.Kwwika", "FK_hubsubscriber_Subscriptions_hubsubscriber_Users", "hubsubscriber_Subscriptions")]
        public EntityCollection<Subscription> hubsubscriber_Subscriptions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Subscription>("HubSubscriber.Kwwika.FK_hubsubscriber_Subscriptions_hubsubscriber_Users", "hubsubscriber_Subscriptions");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Subscription>("HubSubscriber.Kwwika.FK_hubsubscriber_Subscriptions_hubsubscriber_Users", "hubsubscriber_Subscriptions", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
