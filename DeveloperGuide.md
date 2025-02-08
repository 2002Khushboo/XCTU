## Project Architecture
- **XCTU Copy.sln**: Solution file to open the project in Visual Studio.
- **Form1.cs**: Contains the main UI and application logic.
- **MockSerialPort.cs**: Simulates serial communication for testing purposes.
- **TestData/**: Folder containing sample CAN data for testing.
- **Program.cs**: Entry point of the application.

## Adding New Features
1. Create a new feature branch:
   git checkout -b feature/your-feature-name
2. Make the necessary code changes.
3. Test thoroughly using both mock and real hardware if available.
4. Commit your changes with meaningful messages:
   git commit -m "Added feature: descriptive message"
5. Push the branch and create a Pull Request (PR) to dev.
6. Once reviewed, merge into main if stable.


##### **Instructions for Simulating Data During Development**
## Simulation Mode
To enable simulation mode:
1. Open `Project > Properties > Build`.
2. Add `MOCK` to the `Conditional Compilation Symbols`.
3. Ensure `TestData/SampleCANData.csv` is available in the project directory.
4. Run the application; simulated data will be displayed.
