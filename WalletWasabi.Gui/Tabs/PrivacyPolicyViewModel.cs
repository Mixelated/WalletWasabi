using Avalonia.Diagnostics.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using WalletWasabi.Gui.ViewModels;

namespace WalletWasabi.Gui.Tabs
{
	internal class PrivacyPolicyViewModel : WasabiDocumentTabViewModel
	{
		public PrivacyPolicyViewModel(Global global) : base(global, "Privacy Policy")
		{
			PrivacyPolicy = @"
Thank you for your interest in zkSNACKs. The protection of your privacy and thus the protection of your (personal) data is Our highest priority. This policy describes the ways zkSNACKs collect, store, use and protect personal information. The purpose of this policy is to ensure that zkSNACKs complies with applicable European Union (EU) and other statutory data protection laws and regulations, and ensures that users are provided privacy protection.
Data protection laws are generally relevant in case any processing of personal data is concerned. The terms used within the scope of this data protection declaration are defined in and by the General Data Protection Regulation of the European Union. As such, the wide definition of ""processing"" of personal data means any operation or set of operations performed on personal data, such as, but not excluded to, recording, organization, storage, alteration, and transmission of personal data. Any information allowing Us or third parties to potentially identify you in person can be considered personal data. This terminology may also apply to IP addresses, as long as they, e.g. Internet Service Providers, allow such identification.

Personally Identifiable Information
===================================

“Personally identifiable information” (“personal information”) is any information that can be directly associated with a specific person and can be used to identify that person. A prime example of identifiable information is a person’s name.

Handling information
====================

Since we are working on privacy enhancement projects and our mission is to regain personal privacy again our services are designed to be used without indication of any personal data. For this reason we do not have Google Analytics or any other kind of data collecting solutions built into our website. This means that we do not even have any knowledge of the website’s traffic. Visitors may, however, indicate their email addresses voluntarily to get notifications in case of any potential technical problems or other enquiries. These e-mail addresses are solely used to answer users’ questions and are erased after 100 days.
As the main platform for users’ technical questions and issues we use Reddit to answer all questions.
We expressly declare that we do not manage or store any data, such as identification documents, e-mail addresses, names, gender etc.
zkSNACKs does not process any sensitive personal information, such as religion, race, ethnicity and/or political views.
By using the site, you agree with this policy.

All User Information is Confidential
====================================

Your personally identifying information will be kept strictly confidential and never provided to third parties.
All employees of zkSNACKs have been informed about applicable data protection provisions as well as data security measures and are bound to Our privacy practices. All staff are bound by confidentiality agreements.
zkSNACKs will protect processed data adequately against unauthorized access (of third parties) in accordance with the provisions of the legal framework of Gibraltar as well as the European Union. We will only process data which are essential to provide Our services. Data will not be used or stored by other means than set out in this Data Protection Declaration and are made accessible only to a restricted and necessary number of persons. We do not transfer any personal data to third parties without prior explicit consent of the data subject.

Use of Cookies
==============

A cookie is a small piece of data that a website asks your browser to store on your computer or mobile device. The cookie allows the website to “remember” your actions or preferences over time.
We expressly declare that we do not use cookies.

External links, Social media plugins
====================================

As far as the Website contains external links, we hereby indicate that these third-party websites are not subject to the influence and control of zkSNACKs. We disclaim all liability for losses or obligations related to the use of these third-party websites. We are not responsible for the contents, availability, correctness, or accuracy of these websites, nor for their offerings, links, or advertisements.
Our Website uses services and plugins provided by the social media networks like Facebook, Twitter, LinkedIn, etc. By accessing the Website, your browser may instantly communicate with the servers of these networks. Thereby, certain data will be transferred and stored. If you are not logged in to these social media sites or do not have accounts, the information solely refers to your IP address and the fact that the Website has been visited. If you are logged in to any of these, this information can be associated with your account and thus your person. If you do not want to allocate such collected data to your account, you must log out of your profile before visiting the Website. When using the liking/sharing function, information will be transmitted and be visible on social media sites as well. On the other hand, in order to protect your identity you can also use some kind of an identity protection oriented browser.
For the social media sites’ Privacy Policy please visit their own websites and research their corresponding policies.

Changes to this policy
======================

We may amend this policy at any time by posting a revised version on our website. The revised version will be effective at the time we post it. In addition, if the revised version includes any substantial changes to the manner in which your personal information will be processed, we will provide you with 30 days prior notice by posting notification of the change on the “Privacy Policy” area of our website.

Contact details regarding this declaration
==========================================

In case you have any questions concerning zkSNACKs' Data Protection Declaration or if you would like to exercise your right of information, rectification or deletion, please send us a written request outlining your desire to: legal@zksnacks.com.
";

			PrivacyPolicy += new string('\n', 100);
		}

		public string PrivacyPolicy { get; }
	}
}
