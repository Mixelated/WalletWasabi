using Avalonia.Diagnostics.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using WalletWasabi.Gui.ViewModels;

namespace WalletWasabi.Gui.Tabs
{
	internal class TermsAndConditionsViewModel : WasabiDocumentTabViewModel
	{
		public TermsAndConditionsViewModel(Global global) : base(global, "Terms and Conditions")
		{
			TermsAndConditions = @"
PLEASE READ THESE TERMS OF USE CAREFULLY. BY CLICKING AGREE, OR BY ACCESSING OR DOWNLOADING OUR SOFTWARE (AS DEFINED BELOW), YOU AGREE TO BE BOUND BY THESE TERMS OF USE AND ALL TERMS INCORPORATED BY REFERENCE.

If you are accepting these terms on behalf of an entity, you confirm that you are authorised on behalf of that entity to agree to be bound by these Terms of Use and all terms incorporated by reference.

1. GENERAL PROVISIONS
=====================

1.1 SCOPE

This binding Agreement is between zkSNACKs Ltd. (“Service Provider” or “We”) and the person, persons, or entity (“You” or “Your”) using the service, software, or application (“Software”).
These Terms apply to the download of the Client Application (as defined below), any access and use of the Software (as defined below), our website at www.wasabiwallet.io(*) and our Privacy Engine (as defined below), and any of our other services related to or utilizing any of the foregoing, which we refer to in these Terms, collectively, as our “Privacy Oriented Bitcoin Transaction Services” (Services).

1.2 ELIGIBILITY AND AGREEMENT

If you use the Services these Terms apply. If you do not agree to these Terms, you must not use our Services.
You can use our Services only if you are 14 years of age or over and you can lawfully enter into an agreement pursuant to these Terms under applicable law. If you use our Services, you agree to do so in compliance with these Terms and with applicable laws and regulations.

1.3 OUR PRIVACY POLICY

Our Privacy Policy is located at www.wasabiwallet.io(*). Our Privacy Policy is expressly incorporated into these Terms and should be read carefully as it contains important information about how we collect, use, and share your personal data.
We expressly declare that we do not store or collect any personal data other than as defined by our Privacy Policy. We do not record, keep or maintain any records whatsoever about your private key and do not require you to establish an account with us or register on our website in any form.

1.4 CHANGES TO THESE TERMS

We may make changes to these Terms, including when there are changes to our Services, technology or any law or regulation to which we are subject and/or for any other reason. If we do, we will provide you with notice of such changes by posting the updated Terms on our website and changing the “Last Updated” date above. Any amended Terms will become effective no earlier than 14 days after they are posted and will apply prospectively to the use of our Services after such changes become effective, except that any changes addressing new functions of our Services or changes made for legal reasons will come into effect immediately. Your continued use of our Services following the effective date of such changes will constitute your acceptance of such changes. If you do not agree to any amended Terms, you must discontinue using our Services.

2 THE PRIVACY ORIENTED BITCOIN TRANSACTION SERVICES
===================================================

2.1 DESCRIPTION OF SERVICES

We strongly advise to only use our services if you are familiar with cryptocurrencies, especially Bitcoin. We recommend to first learn the basics of Bitcoin and Bitcoin transactions before starting to use our Services.
This Software consists of the Client Application and the Privacy Engine (both as defined below) and functions as a free, open source non-custodial desktop wallet. The Software does not constitute an account where We or other third parties serve as financial intermediaries or custodians of Your bitcoin(s). The Software and our services are therefore exempt from the authority of the Gibraltar Financial Services Commission or any other financial institutions.
While the Software has undergone beta testing and continues to be improved by feedback from the open-source user and developer community, We cannot guarantee there will not be bugs in the Software. You acknowledge that Your use of this Software is at Your own discretion and in compliance with all applicable laws. You are responsible for safekeeping Your passwords, private key pairs, PINs, Recovery Words, and any other codes You use to access the Software.
We expressly declare that we do not store any private keys. Encrypted private key information is stored locally on your computer in a wallet file and/or backed up with Recovery Words, shown at the creation of the wallet. Private keys can be accessed with a password, you have given at the creation of the wallet. It is solely your responsibility to backup and to safekeep your private keys. In case of loss of private keys, you may permanently lose access to your public addresses, since we are not able to recover the private keys for You.
If You do not understand the above paragraph please learn more about Bitcoin transactions before using our Services.
The download and use of the Wasabi Wallet software is subject to the acceptance of our terms and conditions. From the point of downloading we do not store or manage any data, we do not even have knowledge about neither the installation, nor the use of the wallet.
The client application (“Client Application”) is a free and open source application, the sole purpose of which is to grant You access to the Bitcoin Network and our Services (as defined below) without the need or requirement to create or maintain a user account. The application itself is an ordinary Bitcoin desktop wallet with the ordinary features.
The Privacy Oriented Bitcoin Transaction Services is an online service that implements Chaumian CoinJoin to prevent third parties to spy on the Blockchain, and ZeroLink, an end-to-end wallet privacy framework to make sure no privacy leaks happen by any other means. Throughout the process the Service does not initiate or process any standalone transactions whatsoever towards third parties (i.e. non-users of the Service) and therefore does not store or transmit value belonging to others. For further information on how it works please visit our GitHub page: https://github.com/zkSNACKs.
It is your own responsibility to ensure that the use of Wasabi Wallet complies with your local laws and jurisdictions.

2.2 FEES

Subject to the other provisions of these Terms, including, but not limited to Section 4 on Prohibited Activities, you may freely download and use the Client Application without any charge or fee imposed on you by the Service Provider.
The Service Provider does not charge You transaction fees after normal Bitcoin transactions, however You are still subject to transaction fees, charged by the Bitcoin network and received by the Bitcoin miners.
Both the Service Provider and the Bitcoin network charge you transaction fees after CoinJoin Bitcoin transactions. CoinJoin transactions are shared transactions with other users of the wallet. You initiate a CoinJoin transaction by providing unspent transaction outputs to the Service Engine and a CoinJoin round will be executed when a sufficient number of other users provided unspent transaction outputs. The transaction fee, charged by the Service Provider is 0.003% multiplied by the number of users in each round of transaction you initiate, except if:
You are providing the unspent transaction outputs with the smallest accumulated value to the round. In this case You are not being charged with any fees by the Service Provider.
You provided unspent transaction outputs, in a way that in the final CoinJoin transaction would result in a change output back to you that is smaller than or equal to 1% of the denomination of the CoinJoin round. In this rare case, change output will not be generated, to gain an edge on privacy, rather the value of the change output will be added to the fees charged by the Service Provider after the round.
The transaction fees, both charged by the Bitcoin network and the Service Provider shall be automatically processed by our Engine by means of deducting the appropriate amount from the transaction you submit.
YOU EXPRESSLY ACKNOWLEDGE AND AGREE THAT OUR ENGINE AUTOMATICALLY DEDUCTS THE TRANSACTION FEES FROM THE TRANSACTION YOU SUBMITTED FOR THE SERVICES IN LINE WITH THE PREVIOUS PARAGRAPHS.
The Service Provider reserves the right to charge additional fees or to change the amount of fees, and we will provide you at least 30 days advance notice of any such change. The Service Provider reserves the right to waive and/or reduce any fee at any time, with or without notice.

3 PROHIBITED ACTIVITIES
=======================

You agree that you will not use the Services to perform any type of illegal activity of any sort or to take any action that adversely affects the performance of or the provision by the Service Provider of the Services. Furthermore, You agree that you will not use the Services on Bitcoin that is created, received or given in exchange for, or as a result of, any type of illegal activity. The prohibition of this paragraph includes, but is not limited to, the following prohibited activities:
sales of narcotics, research chemicals or any controlled substances;
items that infringe or violate any intellectual property rights such as copyrights, trademarks, trade secrets, or patents;
ammunition, firearms, explosives (including fireworks), or weapons regulated under applicable law or as determined by us; or
transactions that show the personal information of third parties in violation of applicable law;
transactions that support pyramid, Ponzi, or other ""get rich quick"" schemes;
provide credit repair or debt settlement services;
explicit sexual content;
money laundering or any support thereof.
You agree that you will not engage in any of the following activities via the Services, nor will you help or facilitate a third party to engage in any such activity:
attempt to gain unauthorised access to our Engine;
make any attempt to bypass or circumvent any security features;
violate any law, statute, ordinance, regulation or court order;
engage in any activity that is abusive or interferes with or disrupts our Services.
Use of our Services in connection with any transaction involving illegal products or services is expressly prohibited.
The Service Provider reserves the right to temporarily or permanently block you from using the Services if any violation of this section occurs or if we have reasonable grounds to believe that any violation of this section may occur.

4 INDEMNIFICATION
=================

You agree to indemnify, defend and hold us, our employees, agents, consultants, subsidiaries, partners, affiliates, and licensors, harmless against any and all claims, costs, losses, damages, liabilities, judgments and expenses (including reasonable fees of attorneys and other professionals) arising from or in any way related to your use of our Services, your violation of these Terms, or your violation of any rights of any other person or entity.

5 OWNERSHIP OF INTELLECTUAL PROPERTY RIGHTS
===========================================

Our trademarks, service marks, designs, logos, URLs, and trade names that are displayed on our Services we refer to in these Terms collectively as the “Materials”. We hereby grant you a limited, non-exclusive, revocable, royalty-free, non-transferable and non-sublicensable licence to access and use the Materials for your Services use. Such licence is subject to these Terms and does not permit any resale or exploitation of the Materials; the distribution, public performance or public display of any Materials; modifying or otherwise making any derivative uses of the Materials, or any portion thereof; or any use of the Materials other than for their intended purposes. The licence granted under this Section will automatically terminate and be revoked if we suspend or terminate your access to and use of the Services. You agree that the Service Provider will own exclusive rights, including all intellectual property rights, to any feedback, suggestions, ideas or other information or materials relating to the Service Provider or our Services that you provide, whether by email or otherwise, which we refer to in these Terms as “Feedback”. Any Feedback you submit is non-confidential and will become the sole property of the Service Provider. We will be entitled to the unrestricted use and dissemination of such Feedback for any purpose, commercial or otherwise, without acknowledgment or compensation to you. We reserve all rights not expressly granted herein.

6 DISCLAIMER OF WARRANTIES
==========================

Our Services are provided “as is” with no warranty of any kind. Your use of our Services is at your sole risk. We and our licensors, service providers or subcontractors (if any) make no representations or warranties about the suitability of the information, software, products and services contained in our Services for any purpose or their compliance with any accounting rules, principles or laws, and we expressly disclaim any representation or warranty that the Services will be free from errors, viruses or other harmful components, that communications to or from the Services will be secure and will not intercepted, that the services, functions and other capabilities offered by the Services will be uninterrupted, or that their content will be accurate, complete or timely.
EXCEPT AS EXPRESSLY STATED IN THESE TERMS, WE DISCLAIM (TO THE FULLEST EXTENT PERMITTED BY APPLICABLE LAW) ALL WARRANTIES, REPRESENTATIONS AND CONDITIONS, WHETHER EXPRESS OR IMPLIED AND WHETHER IMPOSED BY STATUTE OR OTHERWISE, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES RELATING TO TITLE, NON-INFRINGEMENT, MERCHANTABILITY, AND FITNESS FOR A PARTICULAR PURPOSE. YOU ACKNOWLEDGE THAT YOU HAVE NOT ENTERED INTO THIS AGREEMENT IN RELIANCE UPON ANY STATEMENT, WARRANTY OR REPRESENTATION EXCEPT THOSE EXPRESSLY AND SPECIFICALLY SET FORTH IN THESE TERMS AND THAT YOU SHALL HAVE NO REMEDIES IN RESPECT OF ANY STATEMENT, WARRANTY, REPRESENTATION OR CONDITION THAT IS NOT EXPRESSLY AND SPECIFICALLY SET FORTH IN THESE TERMS. Some jurisdictions do not allow the disclaimer of implied terms in contracts with consumers, so some or all of the disclaimers in this section may not apply to you.

7 NO ADVICE
===========

The Service Provider is not acting and cannot act as an advisor, including as to any financial, legal, investment, insurance and/or tax matters. Any information provided by the Service Provider is for general information only. You are solely responsible for determining whether any contemplated transaction is appropriate for you.
We want to point out that Wasabi Wallet provides WRITTEN support only. We do not currently offer phone support and we will NEVER call, e-mail or get in touch in any form with our users to offer any wallet recovery services. Please be safe and guard your wallet information and funds.

8 LIMITATION OF LIABILITY
=========================

In no event will we, our subsidiaries, partners, affiliates, agents, employees, licensors, service providers or subcontractors (if any), be liable for any indirect, special, incidental, punitive or consequential damages (including, without limitation, loss of profits, loss of revenue, loss of business, loss of use, loss of data, loss of goodwill or any similar or like loss), arising as a result of or in connection with these terms, the performance or operation of our Services, your access to, display of or use of our Services, any delay or inability to access, display or use the Services, any computer viruses, information, software, linked sites, and services obtained through the Services, or the act or omission of any person, business or other third parties using our Services, whether such liability arises from any claim based upon breach of contract, breach of warranty, tort (including negligence), product liability or otherwise, and whether or not we, our licensors, service providers or subcontractors, subsidiaries, partners, affiliates, agents or employees have been advised of the possibility of such damages.
Notwithstanding the foregoing provision, in no event shall the aggregate liability of the Service Provider, our subsidiaries, partners, affiliates, agents, employees, licensors, service providers, or subcontractors (if any) for any loss or damage that arises as a result of, or in connection with, any of the occurrences described above exceed the greater of $100 or the service fees that you paid to us for the service we provide through the Services during the month in which the incident occurred. The limitation of liability reflects the allocation of risk between the parties. The limitations of liability provided in these Terms inure to the benefit of us, our licensors, service providers and subcontractors subsidiaries, partners, affiliates, agents and employees.
Some jurisdictions do not allow certain warranty disclaimers or limitations on liability. Only disclaimers or limitations that are lawful in the applicable jurisdiction will apply to you and our liability will be limited to the maximum extent permitted by law.

9 MISCELLANEOUS PROVISIONS
==========================

9.1 SEVERABILITY

If for any reason a court of competent jurisdiction finds any provision of these Terms to be invalid or unenforceable, that provision will be enforced to the maximum extent permissible and the other provisions of these Terms will remain in full force and effect.

9.2 ARBITRATION

You and the Service Provider agree to arbitrate any dispute arising under or in connection with these Terms or your use of our Services, except for disputes in which either party seeks equitable and other relief for any alleged infringement or unlawful use of copyrights, trademarks, trade names, logos, trade secrets, patents or other intellectual property rights. Arbitration prevents you from suing in court or from having a jury trial. You and the Service Provider agree to notify each other in writing of any dispute within thirty (30) days of when it arises. Notice to the Service Provider shall be sent to legal@zksnacks.com. You and the Service Provider further agree:
to attempt informal resolution prior to any demand for arbitration;
that the seat or legal place of any arbitration will be Gibraltar;
that arbitration will be conducted confidentially by a single arbitrator appointed by the Gibraltar Chamber of Commerce;
the arbitration shall be conducted in accordance with the rules of International Chamber of Commerce; and
that the courts in Gibraltar will have exclusive jurisdiction over any appeals of an arbitration award.
Other than class procedures and remedies discussed below, the arbitrator has the authority to grant any remedy that would otherwise be available in court.
Whether the dispute is heard in arbitration or in court, you and the Service Provider will not commence against the other a class action, class arbitration or representative action or proceeding.

9.3 GOVERNING LAW AND JURISDICTION

These Terms and any dispute or claim between you and the Service Provider arising out of or in connection these Terms or any terms incorporated into these Terms by reference or their subject matter or formation (including non-contractual disputes or claims) will be governed by and construed in accordance with the laws of Gibraltar, without giving effect to any conflict of laws principles that may provide for the application of the law of another jurisdiction. Subject to the “Arbitration” section above, the courts of Gibraltar shall have exclusive jurisdiction to settle any dispute or claim between you and the Service Provider arising out of or in connection with these Terms or any terms incorporated into these Terms by reference or their subject matter or formation (including non-contractual disputes or claims).

9.4 NO WAIVER

Any failure or delay by us to exercise or enforce any right or remedy provided under these Terms or by law will not constitute a waiver of that or any other right or remedy, nor will it preclude any further exercise of that or any other right or remedy. No single or partial right exercise of any right or remedy shall preclude or restrict the further exercise of that or any other right or remedy.

9.5 ASSIGNMENT

The Service Provider may assign these Terms to its parent company, affiliate or subsidiary, or in connection with a merger, consolidation, or sale or other disposition of all or substantially all of its assets. You may not assign these Terms or your use of or access to the Services at any time.

9.6 ENTIRE AGREEMENT
These Terms, together with any other terms incorporated into these Terms by reference and any other terms and conditions that apply to you, constitute the entire and exclusive agreement between us and You regarding its subject matter, and supersede and replace any previous or contemporaneous written or oral contract, warranty, representation or understanding regarding its subject matter. You acknowledge and agree that you shall have no remedies in respect of any statement, representation, assurance or warranty that is not set out in these Terms (or any other terms that are incorporated herein by reference).

9.7 FORCE MAJEURE

Neither You nor We will be liable for delays in processing or other non-performance caused by such events as fires, telecommunications, utility, or power failures, equipment failures, labor strike, riots, war, nonperformance of our vendors or suppliers, acts of God, or other causes over which the respective party has no reasonable control; provided that the party has procedures reasonably suited to avoid the effects of such acts.

9.8 SURVIVING CLAUSES

The provisions of Sections 3-6, 9.2 and 9.3 shall survive the termination of these Terms.

zkSNACKs Ltd.
Address: Suite 3 2nd floor, Icom house 1/5, Irish Town, Gibraltar
Company number: 117429
REID number: GICO.117429-6
www.zksnacks.com(*)

(*) We recommend you to use Tor browser in order to protect your privacy.
			";

			TermsAndConditions += new string('\n', 100);
		}

		public string TermsAndConditions { get; }
	}
}
