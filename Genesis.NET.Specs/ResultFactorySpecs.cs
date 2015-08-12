using System;
using System.Linq;
using Genesis.Net.Entities.Responses.Error;
using Genesis.Net.Entities.Responses.Successful;
using NSpec;

namespace Genesis.Net.Specs
{
    class describe_result_factory : nspec
    {
        void it_should_parse_sale_success_response()
        {
            var successResponseXml =
                                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                    "<payment_response>" +
                                    "<transaction_type>sale</transaction_type>" +
                                    "<status>approved</status>" +
                                    "<authorization_code>345678</authorization_code>" +
                                    "<response_code>00</response_code>" +
                                    "<unique_id>5e2cbbad71d2b13432323153c208223a</unique_id>" +
                                    "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                    "<mode>live</mode>" +
                                    "<timestamp>2007-11-30T14:21:48Z</timestamp>" +
                                    "<descriptor>descriptor one</descriptor>" +
                                    "<amount>9000</amount>" +
                                    "<currency>USD</currency>" +
                                    "<sent_to_acquirer>true</sent_to_acquirer>" +
                                    "</payment_response>";

            successResponseXml.should_parse_to_success_response<SaleSuccessResponse, SaleErrorResponse>();
        }

        void it_should_parse_sale_error_response()
        {
            var errorResponseXml =
                                  "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                  "<payment_response>" +
                                  "<transaction_type>sale</transaction_type>" +
                                  "<status>error</status>" +
                                  "<unique_id>84b6f1c7b89b847ad0ce9035475868da</unique_id>" +
                                  "<transaction_id>10</transaction_id>" +
                                  "<code>330</code>" +
                                  "<technical_message>'card_holder' has invalid format</technical_message>" +
                                  "<message>Please check input data for errors!</message>" +
                                  "<mode>test</mode>" +
                                  "<timestamp>2014-11-11T12:35:47Z</timestamp>" +
                                  "<descriptor>Testing MID</descriptor>" +
                                  "<amount>1000</amount>" +
                                  "<currency>USD</currency>" +
                                  "<sent_to_acquirer>false</sent_to_acquirer>" +
                                  "</payment_response>";

            errorResponseXml.should_parse_to_error_response<SaleSuccessResponse, SaleErrorResponse>();
        }

        void it_should_parse_reconcile_success_response()
        {
            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<payment_response>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<status>approved</status>" +
                                     "<authorization_code>005645</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<unique_id>44177a21403427eb96664a6d7e5d5d48</unique_id>" +
                                     "<transaction_id>119643250547501c79d8295</transaction_id>" +
                                     "<mode>live</mode>" +
                                     "<timestamp>2014-01-30T14:21:48Z</timestamp>" +
                                     "<descriptor>descriptor one</descriptor>" +
                                     "<amount>9000</amount>" +
                                     "<currency>USD</currency>" +
                                     "<sent_to_acquirer>true</sent_to_acquirer>" +
                                     "</payment_response>";

            successResponseXml.should_parse_to_success_response<SingleReconcileSuccessResponse, SingleReconcileErrorResponse>();
        }

        void it_should_parse_reconcile_error_response()
        {
            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<payment_response>" +
                                   "<status>error</status>" +
                                   "<message>Something went wrong, please contact support!</message>" +
                                   "<code>460</code>" +
                                   "<technical_message>Transaction with the given unique ID cannot be found!</technical_message>" +
                                   "</payment_response>";

            errorResponseXml.should_parse_to_error_response<SingleReconcileSuccessResponse, SingleReconcileErrorResponse>();
        }

        void it_should_parse_reconcile_by_date_range_success_response()
        {
            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<payment_responses per_page=\"100\" page=\"2\" total_count=\"19\" pages_count=\"7\">" +
                                     "<payment_response>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<status>approved</status>" +
                                     "<authorization_code>005645</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<unique_id>130319cfb3bf65ff3c4a4045487b174f</unique_id>" +
                                     "<transaction_id>EFBFBC7D-82CD-4375-9A69-15F19C88A134</transaction_id>" +
                                     "<technical_message>Transaction successful!</technical_message>" +
                                     "<message>Transaction successful!</message>" +
                                     "<mode>live</mode>" +
                                     "<timestamp>2014-01-05T15:04:00Z</timestamp>" +
                                     "<descriptor>descriptor one</descriptor>" +
                                     "<amount>500</amount>" +
                                     "<currency>USD</currency>" +
                                     "<sent_to_acquirer>true</sent_to_acquirer>" +
                                     "</payment_response>" +
                                     "<payment_response>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<status>approved</status>" +
                                     "<authorization_code>638745</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<unique_id>130319cfb3bf65ff3c4a4045487b173f</unique_id>" +
                                     "<transaction_id>BBD7945B-BE57-4A14-A7FB-47F7AE928D95</transaction_id>" +
                                     "<technical_message>Transaction successful!</technical_message>" +
                                     "<message>Transaction successful!</message>" +
                                     "<mode>live</mode>" +
                                     "<timestamp>2014-01-05T15:04:00Z</timestamp>" +
                                     "<descriptor>descriptor one</descriptor>" +
                                     "<amount>500</amount>" +
                                     "<currency>USD</currency>" +
                                     "<sent_to_acquirer>true</sent_to_acquirer>" +
                                     "</payment_response>" +
                                     "<payment_response>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<status>approved</status>" +
                                     "<authorization_code>226534</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<unique_id>1e8a6f09253eb8b4f8c84c0d8803713e</unique_id>" +
                                     "<transaction_id>_5041_2013041012_22_10_545</transaction_id>" +
                                     "<technical_message>Transaction successful!</technical_message>" +
                                     "<message>Transaction successful!</message>" +
                                     "<mode>live</mode>" +
                                     "<timestamp>2013-04-10T10:22:13Z</timestamp>" +
                                     "<descriptor>test_descriptor</descriptor>" +
                                     "<amount>50422</amount>" +
                                     "<currency>EUR</currency>" +
                                     "<sent_to_acquirer>true</sent_to_acquirer>" +
                                     "</payment_response>" +
                                     "</payment_responses>";

            successResponseXml.should_parse_to_success_response<MultiReconcileSuccessResponse, MultiReconcileErrorResponse>();
        }

        void it_should_parse_reconcile_by_date_range_error_response()
        {
            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<payment_response>" +
                                   "<status>error</status>" +
                                   "<message>Please check input data for errors!</message>" +
                                   "<code>340</code>" +
                                   "<technical_message>start_date has an invalid format</technical_message>" +
                                   "</payment_response>";

            errorResponseXml.should_parse_to_error_response<MultiReconcileSuccessResponse, MultiReconcileErrorResponse>();
        }

        void it_should_parse_chargeback_success_response()
        {
            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<chargeback_response>" +
                                     "<type>1st chargeback </type>" +
                                     "<arn>74537604221431003881865</arn>" +
                                     "<post_date>2014-01-24</post_date>" +
                                     "<reason_code>4855</reason_code>" +
                                     "<reason_description>Non-receipt of merchandise</reason_description>" +
                                     "<authorization_code>811714</authorization_code>" +
                                     "<amount>14625.5</amount>" +
                                     "<currency>CLF</currency>" +
                                     "<card_number>554960******5069</card_number>" +
                                     "<card_brand>master</card_brand>" +
                                     "<customer_email>emil@example.com</customer_email>" +
                                     "<customer_phone>3598851248512</customer_phone>" +
                                     "<transaction_type>sale3d</transaction_type>" +
                                     "<original_transaction_unique_id>f9634ec5e7dbe6ca3871974accb875cd</original_transaction_unique_id>" +
                                     "</chargeback_response>";

            successResponseXml.should_parse_to_success_response<SingleChargebackSuccessResponse, SingleChargebackErrorResponse>();
        }

        void it_should_parse_chargeback_success_response_2()
        {
            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<chargeback_response>" +
                                     "<type>1st chargeback </type>" +
                                     "<arn>74537604221431003881865</arn>" +
                                     "<post_date>2014-01-24</post_date>" +
                                     "<reason_code>4855</reason_code>" +
                                     "<reason_description>Non-receipt of merchandise</reason_description>" +
                                     "<authorization_code>811714</authorization_code>" +
                                     "<amount>14625</amount>" +
                                     "<currency>CLF</currency>" +
                                     "<card_number>554960******5069</card_number>" +
                                     "<card_brand>master</card_brand>" +
                                     "<customer_email>emil@example.com</customer_email>" +
                                     "<customer_phone>3598851248512</customer_phone>" +
                                     "<transaction_type>sale3d</transaction_type>" +
                                     "<original_transaction_unique_id>f9634ec5e7dbe6ca3871974accb875cd</original_transaction_unique_id>" +
                                     "</chargeback_response>";

            successResponseXml.should_parse_to_success_response<SingleChargebackSuccessResponse, SingleChargebackErrorResponse>();
        }

        void it_should_parse_chargeback_error_response()
        {
            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<chargeback_response>" +
                                   "<technical_message>Chargeback by the given criteria cannot be found!</technical_message>" +
                                   "<status>error</status>" +
                                   "<message>Chargeback not found!</message>" +
                                   "<code>470</code>" +
                                   "</chargeback_response>";

            errorResponseXml.should_parse_to_error_response<SingleChargebackSuccessResponse, SingleChargebackErrorResponse>();
        }

        void it_should_parse_chargeback_by_date_range_success_response()
        {
            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<chargeback_responses per_page=\"100\" page=\"2\" total_count=\"19\" pages_count=\"7\">" +
                                     "<chargeback_response>" +
                                     "<type>1st chargeback </type>" +
                                     "<arn>74537604221431003881865</arn>" +
                                     "<post_date>2014-01-24</post_date>" +
                                     "<reason_code>4855</reason_code>" +
                                     "<reason_description>Non-receipt of merchandise</reason_description>" +
                                     "<authorization_code>811714</authorization_code>" +
                                     "<amount>14625.0</amount>" +
                                     "<currency>USD</currency>" +
                                     "<card_number>554960******5069</card_number>" +
                                     "<card_brand>master</card_brand>" +
                                     "<customer_email>emil@example.com</customer_email>" +
                                     "<customer_phone>3598851248512</customer_phone>" +
                                     "<transaction_type>sale3d</transaction_type>" +
                                     "<original_transaction_unique_id>f9634ec5e7dbe6ca3871974accb875cd</original_transaction_unique_id>" +
                                     "</chargeback_response>" +
                                     "<chargeback_response>" +
                                     "<type>2nd chargeback </type>" +
                                     "<arn>74537604221431003881862</arn>" +
                                     "<post_date>2014-01-27</post_date>" +
                                     "<reason_code>3456</reason_code>" +
                                     "<reason_description>Credit not processed</reason_description>" +
                                     "<authorization_code>123456</authorization_code>" +
                                     "<amount>3456</amount>" +
                                     "<currency>EUR</currency>" +
                                     "<card_number>454360******5008</card_number>" +
                                     "<card_brand>visa</card_brand>" +
                                     "<customer_email>emil@example.com</customer_email>" +
                                     "<customer_phone>3598851248123</customer_phone>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<original_transaction_unique_id>67fbebc172b743a164a3f3af3d010457</original_transaction_unique_id>" +
                                     "</chargeback_response>" +
                                     "</chargeback_responses>";

            successResponseXml.should_parse_to_success_response<MultiChargebackSuccessResponse, MultiChargebackErrorResponse>();
        }

        void it_should_parse_chargeback_by_date_range_error_response()
        {
            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<chargeback_response>" +
                                   "<status>error</status>" +
                                   "<message>Please check input data for errors!</message>" +
                                   "<code>340</code>" +
                                   "<technical_message>start_date has an invalid format</technical_message>" +
                                   "</chargeback_response>";

            errorResponseXml.should_parse_to_error_response<MultiChargebackSuccessResponse, MultiChargebackErrorResponse>();
        }

        void it_should_parse_retrieval_request_success_response()
        {
            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<retrieval_request_response>" +
                                     "<type>Retrieval request</type>" +
                                     "<arn>74537604221431003881865</arn>" +
                                     "<post_date>2014-01-24</post_date>" +
                                     "<reason_code>42</reason_code>" +
                                     "<reason_description>Potential Chargeback</reason_description>" +
                                     "<authorization_code>811714</authorization_code>" +
                                     "<card_number>554960******5069</card_number>" +
                                     "<card_brand>master</card_brand>" +
                                     "<customer_email>emil@example.com</customer_email>" +
                                     "<customer_phone>3598851248512</customer_phone>" +
                                     "<transaction_type>sale3d</transaction_type>" +
                                     "<original_transaction_unique_id>f9634ec5e7dbe6ca3871974accb875cd</original_transaction_unique_id>" +
                                     "</retrieval_request_response>";

            successResponseXml.should_parse_to_success_response<SingleRetrievalRequestSuccessResponse, SingleRetrievalRequestErrorResponse>();
        }

        void it_should_parse_retrieval_request_error_response()
        {
            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<retrieval_request_response>" +
                                   "<technical_message>Retrieval request by the given criteria cannot be found!</technical_message>" +
                                   "<status>error</status>" +
                                   "<message>Retrieval request not found!</message>" +
                                   "<code>480</code>" +
                                   "</retrieval_request_response>";

            errorResponseXml.should_parse_to_error_response<SingleRetrievalRequestSuccessResponse, SingleRetrievalRequestErrorResponse>();
        }

        void it_should_parse_retrieval_request_by_date_range_success_response()
        {
            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<retrieval_request_responses per_page=\"100\" page=\"2\" total_count=\"19\" pages_count=\"7\">" +
                                     "<retrieval_request_response>" +
                                     "<type>Retrieval request</type>" +
                                     "<arn>74537604221431003881865</arn>" +
                                     "<post_date>2014-01-24</post_date>" +
                                     "<reason_code>42</reason_code>" +
                                     "<reason_description>Potential Chargeback</reason_description>" +
                                     "<authorization_code>811714</authorization_code>" +
                                     "<card_number>554960******5069</card_number>" +
                                     "<card_brand>master</card_brand>" +
                                     "<customer_email>emil@example.com</customer_email>" +
                                     "<customer_phone>3598851248512</customer_phone>" +
                                     "<transaction_type>sale3d</transaction_type>" +
                                     "<original_transaction_unique_id>f9634ec5e7dbe6ca3871974accb875cd</original_transaction_unique_id>" +
                                     "</retrieval_request_response>" +
                                     "<retrieval_request_response>" +
                                     "<type>Retrieval request</type>" +
                                     "<arn>74537604221431003881862</arn>" +
                                     "<post_date>2014-01-27</post_date>" +
                                     "<reason_code>42</reason_code>" +
                                     "<reason_description>Potential Chargeback</reason_description>" +
                                     "<authorization_code>123456</authorization_code>" +
                                     "<card_number>454360******5008</card_number>" +
                                     "<card_brand>visa</card_brand>" +
                                     "<customer_email>emil@example.com</customer_email>" +
                                     "<customer_phone>3598851248123</customer_phone>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<original_transaction_unique_id>67fbebc172b743a164a3f3af3d010457</original_transaction_unique_id>" +
                                     "</retrieval_request_response>" +
                                     "</retrieval_request_responses>";

            successResponseXml.should_parse_to_success_response<MultiRetrievalRequestSuccessResponse, MultiRetrievalRequestErrorResponse>();
        }

        void it_should_parse_retrieval_request_by_date_range_error_response()
        {
            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<retrieval_request_response>" +
                                   "<status>error</status>" +
                                   "<message>Please check input data for errors!</message>" +
                                   "<code>340</code>" +
                                   "<technical_message>start_date has an invalid format</technical_message>" +
                                   "</retrieval_request_response>";

            errorResponseXml.should_parse_to_error_response<MultiRetrievalRequestSuccessResponse, MultiRetrievalRequestErrorResponse>();
        }

        void it_should_parse_wpf_reconcile_response_of_successful_payment()
        {
            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<wpf_payment>" +
                                     "<status>approved</status>" +
                                     "<unique_id>26aa150ee68b1b2d6758a0e6c44fce4c</unique_id>" +
                                     "<transaction_id>mtid201104081447161135536962</transaction_id>" +
                                     "<technical_message>TESTMODE: No real money will be transferred!</technical_message>" +
                                     "<message>TESTMODE: No real money will be transferred!</message>" +
                                     "<mode>test</mode>" +
                                     "<timestamp>2011-04-08T14:46:27Z</timestamp>" +
                                     "<amount>5000</amount>" +
                                     "<currency>USD</currency>" +
                                     "<payment_transaction>" +
                                     "<status>approved</status>" +
                                     "<authorization_code>345678</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<unique_id>bad08183a9ec545daf0f24c48361aa10</unique_id>" +
                                     "<transaction_id>mtid201104081447161135536962</transaction_id>" +
                                     "<terminal_token>e9fd7a957845450fb7ab9dccb498b6e1f6e1e3aa</terminal_token>" +
                                     "<mode>test</mode>" +
                                     "<timestamp>2011-04-08T14:46:40Z</timestamp>" +
                                     "<descriptor>descriptor one</descriptor>" +
                                     "<amount>5000</amount>" +
                                     "<currency>USD</currency>" +
                                     "<customer_email>john.doe@example.com</customer_email>" +
                                     "<customer_phone>+11234567890</customer_phone>" +
                                     "<technical_message>TESTMODE: No real money will be transferred!</technical_message>" +
                                     "<message>TESTMODE: No real money will be transferred!</message>" +
                                     "<billing_address>" +
                                     "<first_name>John</first_name>" +
                                     "<last_name>Doe</last_name>" +
                                     "<address1>32, Doestreet</address1>" +
                                     "<address2></address2>" +
                                     "<zip_code>12345</zip_code>" +
                                     "<city>New York</city>" +
                                     "<state>NY</state>" +
                                     "<country>US</country>" +
                                     "</billing_address>" +
                                     "</payment_transaction>" +
                                     "</wpf_payment>";

            successResponseXml.should_parse_to_success_response<WpfReconcileSuccessResponse, WpfReconcileErrorResponse>();
        }

        void it_should_parse_wpf_reconcile_response_of_voided_payment()
        {
            var successResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                     "<wpf_payment>" +
                                     "<status>voided</status>" +
                                     "<unique_id>26aa150ee68b1b2d6758a0e6c44fce4c</unique_id>" +
                                     "<transaction_id>mtid201104081447161135536962</transaction_id>" +
                                     "<technical_message>TESTMODE: No real money will be transferred!</technical_message>" +
                                     "<message>TESTMODE: No real money will be transferred!</message>" +
                                     "<mode>test</mode>" +
                                     "<timestamp>2011-04-08T14:46:27Z</timestamp>" +
                                     "<amount>5000</amount>" +
                                     "<currency>USD</currency>" +
                                     "<payment_transaction>" +
                                     "<status>voided</status>" +
                                     "<authorization_code>345678</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<transaction_type>sale</transaction_type>" +
                                     "<unique_id>bad08183a9ec545daf0f24c48361aa10</unique_id>" +
                                     "<transaction_id>mtid201104081447161135536962</transaction_id>" +
                                     "<terminal_token>e9fd7a957845450fb7ab9dccb498b6e1f6e1e3aa</terminal_token>" +
                                     "<mode>test</mode>" +
                                     "<timestamp>2011-04-08T14:46:40Z</timestamp>" +
                                     "<descriptor>descriptor one</descriptor>" +
                                     "<amount>5000</amount>" +
                                     "<currency>USD</currency>" +
                                     "<customer_email>john.doe@example.com</customer_email>" +
                                     "<customer_phone>+11234567890</customer_phone>" +
                                     "<billing_address>" +
                                     "<first_name>John</first_name>" +
                                     "<last_name>Doe</last_name>" +
                                     "<address1>32, Doestreet</address1>" +
                                     "<address2></address2>" +
                                     "<zip_code>12345</zip_code>" +
                                     "<city>New York</city>" +
                                     "<state>NY</state>" +
                                     "<country>US</country>" +
                                     "</billing_address>" +
                                     "</payment_transaction>" +
                                     "<payment_transaction>" +
                                     "<status>approved</status>" +
                                     "<authorization_code>345678</authorization_code>" +
                                     "<response_code>00</response_code>" +
                                     "<transaction_type>void</transaction_type>" +
                                     "<unique_id>bad08183a9ec545daf0f24c48361aa10</unique_id>" +
                                     "<transaction_id>mtid201104081447161135536962</transaction_id>" +
                                     "<terminal_token>e9fd7a957845450fb7ab9dccb498b6e1f6e1e3aa</terminal_token>" +
                                     "<mode>test</mode>" +
                                     "<timestamp>2011-04-08T14:46:40Z</timestamp>" +
                                     "<descriptor>descriptor one</descriptor>" +
                                     "<amount>5000</amount>" +
                                     "<currency>USD</currency>" +
                                     "</payment_transaction>" +
                                     "</wpf_payment>";

            successResponseXml.should_parse_to_success_response<WpfReconcileSuccessResponse, WpfReconcileErrorResponse>();
        }

        void it_should_parse_init_recurring_sale_error_response()
        {
            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<payment_response>" +
                                   "<transaction_type>init_recurring_sale</transaction_type>" +
                                   "<status>error</status>" +
                                   "<unique_id>d0231d21e0e50afbba1909eadc2f2d6b</unique_id>" +
                                   "<transaction_id>345345</transaction_id>" +
                                   "<code>340</code>" +
                                   "<technical_message>'billing_address[country]' is invalid!</technical_message>" +
                                   "<message>Please check input data for errors!</message>" +
                                   "<mode>test</mode>" +
                                   "<timestamp>2014-11-18T16:18:39Z</timestamp>" +
                                   "<descriptor>Testing MID</descriptor>" +
                                   "<amount>10000</amount>" +
                                   "<currency>USD</currency>" +
                                   "<sent_to_acquirer>false</sent_to_acquirer>" +
                                   "</payment_response>";

            errorResponseXml.should_parse_to_error_response<InitRecurringSaleSuccessResponse, InitRecurringSaleErrorResponse>();
        }

        void it_should_parse_recurring_sale_error_response()
        {
            var errorResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                                   "<payment_response>" +
                                   "<transaction_type>recurring_sale</transaction_type>" +
                                   "<status>error</status>" +
                                   "<unique_id>ce165509205f3a70dfdd190546280b8f</unique_id>" +
                                   "<transaction_id>235245</transaction_id>" +
                                   "<code>420</code>" +
                                   "<technical_message>reference transaction is invalid!</technical_message>" +
                                   "<message>Something went wrong, please contact support!</message>" +
                                   "<mode>test</mode>" +
                                   "<timestamp>2014-11-18T16:45:36Z</timestamp>" +
                                   "<descriptor>Testing MID</descriptor>" +
                                   "<amount>43534500</amount>" +
                                   "<currency>USD</currency>" +
                                   "<sent_to_acquirer>false</sent_to_acquirer>" +
                                   "</payment_response>";

            errorResponseXml.should_parse_to_error_response<RecurringSaleSuccessResponse, RecurringSaleErrorResponse>();
        }

        void it_should_parse_authorize_success_response_with_code_element()
        {
            var errorResponseXml = Mocks.ResponseMocksFactory.CreateAuthorizeSuccessResponse(setCode: true).Xml;
            errorResponseXml.should_parse_to_success_response<AuthorizeSuccessResponse, AuthorizeErrorResponse>();
        }
    }
}
