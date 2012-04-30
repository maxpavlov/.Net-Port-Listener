.Net-Port-Listener
==================

Simple utility that allows a system administrator to select a desired port for testing an open a listening socket. Whenever there is an incoming connection, an application greets the connector.

Perfect for connection problem testing, port binding redirects, etc.

Important notice:
This solution is a disaster from a software architecture point of view. All the logic is in UI layer code. This project was coded wile fixing MS Exchange connectivity problem at a new ISP network, threfore I had not time or intention to implement concerns separation, OOD or loose coupling.