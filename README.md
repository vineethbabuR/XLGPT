# XLGPT: Integrating OpenAI with Microsoft Excel

XLGPT is a proof-of-concept project that seamlessly integrates OpenAI's cutting-edge capabilities into Microsoft Excel, enabling users to leverage powerful AI features directly within their spreadsheets.

## Key Features

- **Modern .NET 6 Framework**: Developed using the latest .NET 6 for robust performance and compatibility.
- **State-of-the-Art GPT Models**: Leverages OpenAI's advanced GPT models for natural language processing tasks.
- **Customizable Chat Parameters**: User interface elements to adjust key chat parameters, with more features planned in future updates.
- **Excel Ribbon Integration**: Provides a dedicated XLGPT ribbon for easy access to AI-powered functionalities.

## Project Overview

Here’s a preview of XLGPT in action:

![XLGPT Screenshot](assets/UIImage.JPG)


## Prerequisites

Before running XLGPT, ensure the following requirements are met:

1. **.NET 6 SDK**: Install the .NET 6 SDK on your local machine. [Download here](https://dotnet.microsoft.com/download).
2. **OpenAI API Token**: If connecting to OpenAI's API, ensure you have a valid OpenAI API key.

## Installation and Usage

Follow these steps to set up and use XLGPT:

1. **Clone the Repository**:  
   ```bash
   git clone https://github.com/vineethbabuR/XLGPT.git
   cd XLGPT
   ```

2. **Open the Project in Visual Studio**:  
   Open the solution file (`.sln`) using [Visual Studio 2022](https://visualstudio.microsoft.com/vs/).

3. **Build the Project**:  
   Build the solution using the `Release` configuration to generate the Excel Add-In (`.xll`) files.

4. **Locate the Add-In File**:  
   Navigate to the `bin\Release` folder under the relevant architecture (`x64` or `x86`) to find the `.xll` file.

5. **Install the Add-In in Excel**:  
   - Double-click the `.xll` file to load it as an Excel Add-In.  
   - Alternatively, manually add it via **File > Options > Add-Ins > Excel Add-Ins > Browse**.

6. **Access XLGPT Features**:  
   Open Excel, and navigate to the **XLGPT** ribbon to start using the AI-powered functionalities.

## How It Works

XLGPT acts as an intermediary between Excel and OpenAI, allowing users to send prompts to OpenAI's GPT models and receive responses directly in their spreadsheets. The project is designed to be lightweight, extensible, and easy to integrate with existing Excel workflows.

## Contributing

We welcome contributions to enhance XLGPT! To contribute:

1. Fork the repository.
2. Create a feature branch:
   ```bash
   git checkout -b feature-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add feature description"
   ```
4. Push to the branch:
   ```bash
   git push origin feature-name
   ```
5. Open a Pull Request.

## Roadmap

- **Enhanced UI**: Additional controls for fine-tuning OpenAI model parameters.
- **Model Selection**: Support for selecting between GPT-3.5, GPT-4, and other future models.
- **Custom Integrations**: Enabling support for other AI/ML frameworks.
- **Logging and Debugging Tools**: Improved tools for debugging and logging API interactions.
- **Local LLM Integration**: Enabling local LLM (e.g., LLaMA) integration.

## License

This project is licensed under the **GNU General Public License v3.0**. See the [LICENSE](LICENSE) file for details.

## Support

For questions or feedback, please feel free to raise an issue on GitHub or contact us directly at [vineethbabu4424@hotmail.com].

## Acknowledgments

- Govert van Drimmelen of ExcelDNA: Without this library, the work would have remained a concept.
- The creators of openai-dotnet: For building a robust and well-documented wrapper, enabling seamless integration with OpenAI's API.
- OpenAI for providing state-of-the-art AI models.
- The developers of .NET for their robust and modern development framework.
- Microsoft Excel for being a versatile platform for innovation.
