# Finbourne.Luminesce.Sdk.Model.CaseStatementItem
Information about a case statement.  A typical case statement would look like:  CASE WHEN Field {Filter} Source THEN Target  For example: CASE WHEN 'currency' = 'USD' THEN 'US'  Here the Field is 'currency', the Source is 'USD', the Filter is '=', and the Target is 'US'

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filter** | **string** | The operator in the case statement SQL expression | 
**Source** | **string** | The expression that is on the LHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target | 
**Target** | **string** | The expression that is on the RHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target | 
**IsTargetNonLiteral** | **bool** | The Target can be a literal value or a non literal (field) and  hence will be interpreted differently.  This can be determined from the UI and passed down as a true / false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

