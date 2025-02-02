using System;
using System.Collections.Generic;
using System.Text;
using WalletWasabi.Gui.ViewModels;

namespace WalletWasabi.Gui.Tabs
{
	internal class LegalIssuesViewModel : WasabiDocumentTabViewModel
	{
		public LegalIssuesViewModel(Global global) : base(global, "Legal Issues")
		{
			LegalIssues = @"
Legal statement of Wasabi Wallet
The purpose of Wasabi Wallet is to provide privacy for its users’ Bitcoin transactions. This means that with the use of the wallet we would like to enable the users to make Bitcoin payments in a way that their spending history, address balances, etc. are not visible for the receiver party. This does not necessarily mean that the user stays anonymous, since the receiver party might have to identify the sending party.
Our goal is to minimize the leaked financial private information to third parties and the receiver itself.
zkSNAKCs Ltd., the owner and creator of Wasabi Wallet only supports behaviour that is legally acceptable by Gibraltarian and international legal standards and strictly rejects any kinds of illegal activities. If needed zkSNACKs Ltd. closely cooperates with law enforcement agencies up to its possible resources.

INFORMATION PROVIDED
====================

Wasabiwallet.io (Website) provides information and material of a general nature. You are not authorized and nor should you rely on the Website for legal advice, investment advice, or advice of any kind. You act at your own risk in reliance on the contents of the Website. If you make a decision to act or not act, you should contact a licensed attorney in the relevant jurisdiction in which you want or need help. In no way are the owners of, or contributors to, the Website responsible for the actions, decisions, or other behavior taken or not taken by you in reliance upon the Website or the use of Wasabi Wallet.

INVESTMENT RISKS
================

The investment in Bitcoin can lead to loss of money over short or even long periods of time. The investors in Bitcoin should expect prices to have large range fluctuations. The information published on the Website cannot guarantee that the investors in Bitcoin would not lose money.

COMPLIANCE WITH TAX OBLIGATIONS
===============================

The users of the Wallet are solely responsible to determine what, if any, taxes apply to their Bitcoin transactions. The owners of, or contributors to, the Wallet are NOT responsible for determining the taxes that apply to Bitcoin transactions.

WASABI WALLET DOES NOT STORE, SEND, OR RECEIVE BITCOINS
=======================================================

The Wasabi Wallet does not store, send or receive bitcoins. This is because Bitcoins exist only by virtue of the ownership record maintained in the Bitcoin network. Any transfer of title in bitcoins occurs within a decentralized Bitcoin network, and not on the Wasabi Wallet.

LIMITATION OF LIABILITY
=======================

Unless otherwise required by law, in no event shall the owners of, or contributors to, the Wasabi wallet be liable for any damages of any kind, including, but not limited to, loss of use, loss of profits, or loss of data arising out of or in any way connected with the use of the Wallet.

WASABI WALLET’S TRADEMARKS
==========================

""wasabiwallet.io"", ""Wasabi Wallet"", and all logos related to the Wasabi Wallet services are either trademarks or used as trademarks of Wasabi Wallet like the product of zkSNACKs Ltd.. You may use the logos provided by Wasabi Wallet for the purpose of directing web traffic to the Wasabi Wallet services. You may not alter, modify or change these logos in any way, use them in a manner that mischaracterizes zkSNACKs or the Wasabi Wallet services or display them in any manner that implies zkSNACKs’ sponsorship or endorsement.

COUNTRY OF RESIDENCE
====================

In case if you are a Gibraltar residence person and willing to use Wasabi Wallet please inform us in advance on the following e-mail address: legal@zksnacks.com.
			";

			LegalIssues += new string('\n', 100);
		}

		public string LegalIssues { get; }
	}
}
