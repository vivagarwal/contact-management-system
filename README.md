# Contact Management System

A simple Contact Management System built using .NET and C#. This application allows users to manage their contacts efficiently, including adding, editing, and deleting contact information.

## Features

- Add new contacts
- Edit existing contacts
- Delete contacts
- View all contacts in a list

## Screenshots

Below are some screenshots of the application:

1. **Homepage**: 
   ![Homepage](screenshorts/Screenshot%202024-09-03%20at%2012.01.25 PM.png)

2. **Add Contact**: 
   ![Add Contact](screenshorts/Screenshot%202024-09-03%20at%2011.58.12 AM.png)

3. **Delete Contact**: 
   ![Delete Contact](screenshorts/Screenshot%202024-09-03%20at%2012.01.30 PM.png)

## Prerequisites

Make sure you have the following installed on your machine:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)

### Installing .NET SDK

#### On macOS

1. **Install Homebrew** (if you don’t have it installed):

    ```bash
    /bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
    ```

2. **Install .NET SDK using Homebrew:**

    ```bash
    brew install --cask dotnet-sdk
    ```

3. **Verify the installation:**

    ```bash
    dotnet --version
    ```

#### On Windows

1. **Download the .NET SDK installer** from the [.NET download page](https://dotnet.microsoft.com/download).

2. **Run the installer** and follow the setup instructions.

3. **Verify the installation:**

    Open Command Prompt or PowerShell and run:

    ```powershell
    dotnet --version
    ```

## Running the Application

1. **Clone the repository:**

    ```bash
    git clone https://github.com/vivagarwal/contact-management-system.git
    ```

2. **Navigate to the project directory:**

    ```bash
    cd MyMvcApp
    ```

3. **Restore the project dependencies:**

    ```bash
    dotnet restore
    ```

4. **Build the project:**

    ```bash
    dotnet build
    ```

5. **Run the application:**

    ```bash
    dotnet run
    ```

6. **Open your web browser and navigate to:**

    ```
    http://localhost:5000
    ```

## Configuration

You can configure the application settings in the `appsettings.json` file located in the root directory. Make sure to set up any necessary database connections or other settings as required.

## Contributing

If you would like to contribute to this project, please fork the repository and create a pull request with your changes. Make sure to follow the coding conventions and add appropriate tests for your changes.

