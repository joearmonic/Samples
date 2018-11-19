import React from 'react';
import { LinkContainer } from 'react-router-bootstrap';
import { Media, Button, Row, Col, Grid, FormGroup, FormControl, ControlLabel, Form, Table } from 'react-bootstrap';
import { dataService } from '../stores/dataService';

const api = 'api/Terminal/Get/';

export default class Terminal extends React.Component {
    constructor(props) {
        super(props);

        this.state = { terminal: {}, loading: true };

        const { id } = props ? props.match.params : this.props.match.params;
        dataService.getJSON(api + id, data => {
            this.setState({ terminal: data, loading: false });
        });
    }

    render() {
        const terminal = this.state.terminal;

        return (
            <Grid fluid>
                <Row className="top-actionbar">
                    <Col xs={4}>
                        <LinkContainer to="/Terminals">
                            <Button bsStyle="info">Volver al listado</Button>
                        </LinkContainer>
                    </Col>
                    <Col xs={8}><Button bsStyle="primary" className="pull-right">Editar</Button></Col>
                </Row>
                <Row>
                    <Col>
                        <Media className="device-article">
                            <Media.Left align="top">
                                <img width={171} height={180} src="/thumbnail.png" alt="thumbnail" />
                            </Media.Left>
                            <Media.Body>
                                <Media.Heading>Terminal #{this.props.match.params.id}</Media.Heading>
                                <Form horizontal>
                                    <FormGroup>
                                        <Col componentClass={ControlLabel} sm={4} lg={3}>Software version</Col>
                                        <Col sm={5} lg={4}>
                                            <FormControl type="text" placeholder="Software Version" value={terminal.TemplateName} />
                                        </Col>
                                    </FormGroup>
                                    <FormGroup>
                                        <Col componentClass={ControlLabel} sm={4} lg={3}>Number</Col>
                                        <Col sm={5} lg={4}>
                                            <FormControl type="text" placeholder="Phone number" value={terminal.Number} />
                                        </Col>
                                    </FormGroup>
                                    <FormGroup>
                                        <Col componentClass={ControlLabel} sm={4} lg={3}>Template Version</Col>
                                        <Col sm={5} lg={4}>
                                            <FormControl type="text" placeholder="Template Version" value={terminal.TemplateName} />
                                        </Col>
                                    </FormGroup>
                                </Form>
                            </Media.Body>
                        </Media>
                    </Col>
                </Row>
                <h4>Configured parameters</h4>
                <Table className='table table-hover'>
                    <thead>
                        <tr>
                            <th>Parameter Key</th>
                            <th>Description</th>
                            <th>ConfiguredValue</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr><td>1120</td>
                            <td>Activar opciones GPS</td>
                            <td>Sí</td></tr>
                    </tbody>
                </Table>
            </Grid>
        );
    }
}