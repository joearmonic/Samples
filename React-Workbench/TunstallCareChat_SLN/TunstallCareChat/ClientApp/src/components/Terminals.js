import React from 'react';
import { Table } from 'react-bootstrap';
import { Link } from 'react-router-dom';

export class Terminals extends React.Component {
    static renderTable(terminals) {
        return (
            <Table className='table table-hover'>
                <thead>
                    <tr>
                        <th>Terminal Id</th>
                        <th>Phone Number</th>
                        <th>Template Version</th>
                        <th>Control Centre</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        terminals.map(terminal =>
                            <tr key={terminal.id}>
                                <td><Link to={'/terminal/' + terminal.id}>{terminal.id}</Link></td>
                                <td>{terminal.number}</td>
                                <td>{terminal.templateName}</td>
                                <td>{terminal.controlCentre}</td>
                            </tr>
                        )
                    }
                </tbody>
            </Table>
        );
    }

    displayName = Terminals.name;

    constructor(props) {
        super(props);
        this.state = { terminals: [], loading: true };

        fetch('api/Terminal/GetAll')
            .then(response => response.json())
            .then(data => {
                this.setState({ terminals: data, loading: false });
            });
    };

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Terminals.renderTable(this.state.terminals);

        return (
            <div>
                <h1>TCC Terminals.<small> Devices installed and Programmables.</small></h1>
                {contents}
            </div>
        );
    }
}