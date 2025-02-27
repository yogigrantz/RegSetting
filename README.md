# RegSetting

A simple class to get and set windows registry setting

## Installation

Include this package in the project file 

## Usage

In Winform program.cs, add this statement to initialize Registry setting for that particular app:

      RegistrySetting.CurrentUserKey = "Clocker";


And then from anywhere in the application do the following to save application setting to the system registry:

for example: 

    RegistrySetting.SetRegistryValue(nameof(txtInvoiceNbr), txtInvoiceNbr.Text); 

And for retrieving the registry setting:

    txtInvoiceNbr.Text = RegistrySetting.GetRegistryValue(nameof(txtInvoiceNbr));


## Examples




## Dependencies

Microsoft.NetCore.App   

## Contributing

Any new ideas on how to enhance this class without adding much complexity, please adhere to SOLID principle   

## License

This project is licensed under the MIT License(LICENSE).  
