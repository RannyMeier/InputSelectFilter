# InputSelectFilter

https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/components

https://blazor.radzen.com/dropdown

https://github.com/dotnet/aspnetcore/blob/afacc8740c40bf465da9b9a34914a2d88d243b3c/src/Components/Web/src/Forms/InputSelect.cs

https://github.com/radzenhq/radzen-blazor/blob/master/Radzen.Blazor/DropDownBase.cs

1) Please fix Orders.razor tbody to use new InputSelectNumberFilter component for Entity and Item.
2) Like Blazor InputSelect with added search, filter, and bind to integer.
3) Like Radzen DropDown with integrated Search text box, delay, and filter.
4) public sealed class InputSelectFilter : InputBase
5) Control also has a textbox for up to three search terms.
6) Filter: ValStrs.Contains(term1) & ValStrs.Contains(term2) & ValStrs.Contains(term3)
7) OnInput event filters list after input time delay about 1200ms.
8) Control has a listbox for filtered result.
9) Binds to integer in Orders list.
10) Display Name in select list.
11) Filter on ValStrs property.
12) Bind Id to property in form Orders context.
