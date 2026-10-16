# How to Upload an Excel File and Bind to Blazor DataGrid

## Overview

This sample demonstrates how to upload an Excel workbook and bind the imported data to the Syncfusion [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid). The application reads spreadsheet content from an uploaded Excel file, converts the worksheet data into a format suitable for data binding, and displays the imported records within the DataGrid. This approach is useful in scenarios where users need to load external spreadsheet data into a web application for viewing, filtering, sorting, or further processing without requiring a database import step.

## Key Features

- Demonstrates Excel file upload within a Blazor application.
- Reads spreadsheet data from a user-selected Excel workbook.
- Imports worksheet records and prepares them for DataGrid binding.
- Dynamically updates the Syncfusion Blazor DataGrid using uploaded Excel data.
- Illustrates an Excel-to-DataGrid workflow without requiring a preconfigured database.
- Includes framework-specific implementations for both .NET 5 and .NET 7 sample projects.
- Provides a practical example of loading external spreadsheet content into a web-based grid interface.
- Demonstrates client-side data presentation after successful Excel processing and import.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download the repository.
2. Open the appropriate solution from either:
   - `net-5.0`
   - `net-7.0`
3. Restore all NuGet packages.
4. Set the corresponding startup project if required.
5. Build the solution.
6. Run the application using `Ctrl+F5`.
7. Upload an Excel file through the application UI to populate the DataGrid.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the desired project folder.

```bash
cd net-7.0
dotnet restore
dotnet run
```

4. Open the local URL displayed in the terminal after the application starts.
5. Upload an Excel workbook to view the imported records in the DataGrid.

## Project Structure

- `net-5.0/` — contains the .NET 5 implementation of the Excel upload and DataGrid binding sample.
- `net-7.0/` — contains the .NET 7 implementation of the Excel upload and DataGrid binding sample.
- `Pages/` — contains the Blazor page that hosts the file upload workflow and DataGrid rendering logic.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For feature documentation, see the Syncfusion Blazor DataGrid documentation: https://help.syncfusion.com/grid-sdk/blazor/data-grid/overview

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
