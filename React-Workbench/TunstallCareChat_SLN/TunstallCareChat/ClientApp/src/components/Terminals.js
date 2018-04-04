import React from 'react';
import {Table} from 'react-bootstrap';

export class Terminals extends React.Component {
    displayName = Terminals.name;

    constructor(props){
        super(props);
        this.state = {terminals : [], loading: true};

        fetch('api/Terminal/GetAll')
      .then(response => response.json())
      .then(data => {
        this.setState({ terminals: data, loading: false });
      });
    }

    static renderTable(terminals) {
        return (
          <Table className='table'>
            <thead>
              <tr>
                <th>Terminal Id</th>
                <th>Phone Number</th>
                <th>Template Id</th>
                <th>Centre Id</th>
              </tr>
            </thead>
            <tbody>
              {terminals.map(terminal =>
                <tr key={terminal.TerminalId}>
                  <td>{terminal.Number}</td>
                  <td>{terminal.TemplateId}</td>
                  <td>{terminal.CentreId}</td>
                </tr>
              )}
            </tbody>
          </Table>
        );
      }
    
      render() {
        let contents = this.state.loading
          ? <p><em>Loading...</em></p>
          : Terminals.renderTable(this.state.terminals);
    
        return (
          <div>
            <h1>TCC Terminals.<small> Devices installed and Programmables.</small></h1>
            <p>This component demonstrates fetching data from the server.</p>
            {contents}
          </div>
        );
      }
}