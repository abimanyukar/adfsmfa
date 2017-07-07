﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neos.IdentityServer.MultiFactor.Resources {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class errors_strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal errors_strings() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Neos.IdentityServer.MultiFactor.Resources.errors_strings", typeof(errors_strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
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
        ///   Recherche une chaîne localisée semblable à Access allowed ! but your account is not enabled ! a request has been sended to administartors, you will be notified soon of the activation process..
        /// </summary>
        internal static string ErrorAccountAdminAuthorized {
            get {
                return ResourceManager.GetString("ErrorAccountAdminAuthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Access not allowed ! your account is not enabled ! a request has been sended to administartors, you will be notified soon of the activation process..
        /// </summary>
        internal static string ErrorAccountAdminNotEnabled {
            get {
                return ResourceManager.GetString("ErrorAccountAdminNotEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Access allowed ! but your account is not enabled ! it is recommanded that you provide now all required informations or contact your administartors, they will notify you about the activation process..
        /// </summary>
        internal static string ErrorAccountAuthorized {
            get {
                return ResourceManager.GetString("ErrorAccountAuthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Unauthorized access ! Your account is not activated ! Please contact the administrators to start the activation process or validate the previous form !.
        /// </summary>
        internal static string ErrorAccountNoAccess {
            get {
                return ResourceManager.GetString("ErrorAccountNoAccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Access not allowed ! your account is not enabled ! Please contact your administrators for more informations..
        /// </summary>
        internal static string ErrorAccountNotEnabled {
            get {
                return ResourceManager.GetString("ErrorAccountNotEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Error on authentication process ! 
        ///{0}.
        /// </summary>
        internal static string ErrorAuthenticating {
            get {
                return ResourceManager.GetString("ErrorAuthenticating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Email invalid format !.
        /// </summary>
        internal static string ErrorEmailException {
            get {
                return ResourceManager.GetString("ErrorEmailException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Error invalid email format : 
        ///{0}.
        /// </summary>
        internal static string ErrorInvalidEmail {
            get {
                return ResourceManager.GetString("ErrorInvalidEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Invalid identification, please restart your session..
        /// </summary>
        internal static string ErrorInvalidIdentificationRestart {
            get {
                return ResourceManager.GetString("ErrorInvalidIdentificationRestart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Operation canceled, password invalid !.
        /// </summary>
        internal static string ErrorInvalidPassword {
            get {
                return ResourceManager.GetString("ErrorInvalidPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Incorrect phone number !.
        /// </summary>
        internal static string ErrorInvalidPhoneException {
            get {
                return ResourceManager.GetString("ErrorInvalidPhoneException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Error loading Configuration File : 
        ///{0}.
        /// </summary>
        internal static string ErrorLoadingConfigurationFile {
            get {
                return ResourceManager.GetString("ErrorLoadingConfigurationFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Error loading Configuration File : Not Found !.
        /// </summary>
        internal static string ErrorLoadingConfigurationFileNotFound {
            get {
                return ResourceManager.GetString("ErrorLoadingConfigurationFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Error loading User Registration ! 
        ///{0}.
        /// </summary>
        internal static string ErrorLoadingUserRegistration {
            get {
                return ResourceManager.GetString("ErrorLoadingUserRegistration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Warning ! the user {0} has choosen to connect via a procedure with an untrusted email address : {1}. This email must be set in the standard registration procedure, this is not the case. Perhaps that the email validation option was not active when the user has registered. This is not a normal condition ! Please, investigate, it&apos;s maybe a legitim connection..
        /// </summary>
        internal static string ErrorRegistrationEmptyEmail {
            get {
                return ResourceManager.GetString("ErrorRegistrationEmptyEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Error when sending identification request !.
        /// </summary>
        internal static string ErrorSendingToastInformation {
            get {
                return ResourceManager.GetString("ErrorSendingToastInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Window validation time elapsed..
        /// </summary>
        internal static string ErrorValidationTimeWindowElapsed {
            get {
                return ResourceManager.GetString("ErrorValidationTimeWindowElapsed", resourceCulture);
            }
        }
    }
}