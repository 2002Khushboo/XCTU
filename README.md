# XCTU Copy CAN Data Logger

## **Project Overview**
The **XCTU Copy CAN Data Logger** is a desktop application built using C# and Windows Forms Application (WFA) on Visual Studio. This application interfaces with an Arduino microcontroller equipped with a CAN module to capture and log data from hardware components such as motors, batteries, power supplies, and controllers. The collected data is displayed in the application and logged to an Excel sheet for analysis.

## **Features**
- Real-time data logging from CAN-enabled devices
- Display of CAN data parameters in the desktop application
- Logging and exporting data to Excel for further analysis
- Serial communication interface with Arduino for data transmission

## **How to Build and Run the Application**

### **Prerequisites**
1. **Software:**
   - Visual Studio 2019 or later
   - .NET Framework 4.7.2 or higher
   - Arduino IDE (for uploading the sketch to the microcontroller)

2. **Hardware:**
   - Arduino board (e.g., Arduino Uno)
   - CAN module (e.g., MCP2515 CAN Controller)
   - CAN-enabled devices (motor, battery, controller, etc.)
   - USB cable for Arduino connection

### **Steps to Build and Run**
1. **Clone the Repository:**
   ```bash
   git clone <repository-url>
   cd XCTU-Copy-CAN-Data-Logger
   ```

2. **Open the Project in Visual Studio:**
   - Double-click the `xctu copy.sln` file.

3. **Build the Solution:**
   - Select `Build > Build Solution` or press `Ctrl + Shift + B`.

4. **Upload the Arduino Sketch:**
   - Open the provided Arduino sketch in the `Documentation/ArduinoCode/` folder.
   - Connect your Arduino board and select the correct port.
   - Upload the sketch to the board.

5. **Run the Application:**
   - Press `F5` or select `Debug > Start Debugging`.

6. **Connect Hardware:**
   - Ensure the CAN module is properly connected to the Arduino and CAN bus.

7. **Monitor Data:**
   - The application will display real-time data and log it to an Excel sheet.

## **Dependencies**
- .NET Framework 4.7.2 or higher
- Arduino IDE
- Excel Interop for data logging

## **Hardware Requirements**
- Arduino board (e.g., Arduino Uno)
- MCP2515 CAN Module
- CAN bus-enabled devices (motor, battery, controller, etc.)
- Power supply for hardware components

## **Example Screenshots and Use Cases**
### **Dashboard Example**
[Insert a screenshot of the application dashboard here]

### **Excel Log Example**
[Insert a screenshot of a sample Excel log here]

### **Use Cases:**
- Performance monitoring of motor and battery parameters
- Debugging CAN-based control systems
- Data analytics for hardware optimization

## Contributing
We welcome contributions! Follow these steps to get started:
1. Fork the repository.
2. Clone your fork and create a feature branch.
3. Commit changes and submit a Pull Request.
4. Wait for review and approval.

## **License**
This project is licensed under the [MIT License](LICENSE).

---
Feel free to modify this README to fit the specific requirements and details of your project.

