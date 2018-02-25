import React from 'react'
import { Panel, Button } from 'react-bootstrap'
import Form from 'react-jsonschema-form'

class Login extends React.PureComponent {
    constructor(props) {
        super(props);
    }

    render() {
        const formSchema = {
            type: 'object',
            required: ['email', 'password'],
            properties: {
                email: {
                    type: 'string',
                    title: 'Email',
                    format: 'email'
                },
                password: {
                    type: 'string',
                    title: 'Password'
                }
            }
        }

        const uiSchema = {
            password: { 'ui:widget': 'password' }
        }


        return (
            <section>
                <div className="container">
                    <Panel bsStyle="info">
                        <Panel.Heading>
                            <Panel.Title componentClass="h1">Login</Panel.Title>
                        </Panel.Heading>
                        <Panel.Body>
                            <Form className="col-lg-8 col-lg-offset-2 col-md-8 col-md-offset-2 col-sm-8 col-sm-offset-2"
                                noHtml5Validate={true}
                                schema={formSchema}
                                uiSchema={uiSchema}
                                onSubmit={this.onSubmit}>
                                <div className="row">
                                    <div className="col-lg-6">
                                        <Button type="submit" bsStyle="success">Submit</Button>
                                    </div>
                                </div>
                            </Form>
                        </Panel.Body>
                    </Panel>
                </div>
            </section>
        )
    }

}

export default Login;